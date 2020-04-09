using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace Delta_X_Software.Net
{
    public partial class Form1 : Form
    {
        // ----------- Win32 API -------------
        [DllImport("User32.dll")]
        static extern bool MoveWindow(IntPtr handle, int x, int y, int width, int height, bool redraw);

        internal delegate int WindowEnumProc(IntPtr hwnd, IntPtr lparam);
        [DllImport("user32.dll")]
        internal static extern bool EnumChildWindows(IntPtr hwnd, WindowEnumProc func, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private Process process;
        private IntPtr unityHWND = IntPtr.Zero;

        private const int WM_ACTIVATE = 0x0006;
        private readonly IntPtr WA_ACTIVE = new IntPtr(1);
        private readonly IntPtr WA_INACTIVE = new IntPtr(0);
        // -----------------------------------

        SerialPort DeltaXPort;
        String ReceivedData;
        String TransmitedData;
        List<String> GcodeCommands;

        String XHome = "";
        String YHome = "";
        String ZHome = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitVariables();
            GetAvailableSerialPorts(null, null);
        }

        void InitVariables()
        {
            DeltaXPort = new SerialPort();
            DeltaXPort.DataReceived += new SerialDataReceivedEventHandler(WhenDeltaXPortReceiveData);

            GcodeCommands = new List<String>();

            //RunEmbedWindow(Directory.GetCurrentDirectory() + "/ROS/Delta X Ros.exe");
            
        }

        bool IsROSRunning = false;

        private void RunEmbedWindow(String filename)
        {
            try
            {
                process = new Process();
                process.StartInfo.FileName = filename;
                process.StartInfo.Arguments = "-parentHWND " + pnDeltaXROS.Handle.ToInt32() + " " + Environment.CommandLine;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                process.WaitForInputIdle();
                // Doesn't work for some reason ?!
                //unityHWND = process.MainWindowHandle;
                EnumChildWindows(pnDeltaXROS.Handle, WindowEnum, IntPtr.Zero);

                Task.Delay(500).ContinueWith(t =>
                {
                    MoveWindow(unityHWND, 0, 0, pnDeltaXROS.Width, pnDeltaXROS.Height, true);
                    ActivateUnityWindow();
                });

                IsROSRunning = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ".\nCheck if DeltaXRos.exe is placed next to Delta_X_Software.Net.exe.");
            }
        }

        private int WindowEnum(IntPtr hwnd, IntPtr lparam)
        {
            unityHWND = hwnd;
            ActivateUnityWindow();
            return 0;
        }

        private void ActivateUnityWindow()
        {
            SendMessage(unityHWND, WM_ACTIVATE, WA_ACTIVE, IntPtr.Zero);
        }

        private void DeactivateUnityWindow()
        {
            SendMessage(unityHWND, WM_ACTIVATE, WA_INACTIVE, IntPtr.Zero);
        }

        private void WhenDeltaXPortReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(GetDataFromDeltaXPort));
        }

        private void GetDataFromDeltaXPort(object sender, EventArgs e)
        {
            ReceivedData = DeltaXPort.ReadLine();
            ProcessReceivedData(ReceivedData);

            tbReceive.Text += ReceivedData + "\n";

            tbReceive.Select(tbReceive.Text.Length, 0);

            tbReceive.ScrollToCaret();
        }

        void ProcessReceivedData(String data)
        {
            try
            {
                if (TransmitedData == "Position")
                {
                    string[] values = data.Split(',');

                    if (values.Length == 3)
                    {
                        XHome = tbX.Text = values[0];
                        YHome = tbY.Text = values[1];
                        ZHome = tbZ.Text = values[2];

                         
                    }                    
                }

                if (data.Substring(0, 2) == "Ok")
                {
                    TransmitGcodeLineInGcodeEditor();
                }
            }
            catch
            {

            }
        }

        void GetAvailableSerialPorts(object sender, EventArgs e)
        {
            cbPortList.Items.Clear();

            foreach (string name in SerialPort.GetPortNames())
            {
                cbPortList.Items.Add(name);
            }

            if (cbPortList.Items.Count > 0)
            {
                cbPortList.SelectedIndex = 0;
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (cbPortList.Text == "")
                return;

            if (btConnect.Text == "Connect")
            {
                DeltaXPort.PortName = cbPortList.Text;
                DeltaXPort.BaudRate = int.Parse(cbBaudrate.Text);
                try
                {
                    DeltaXPort.Open();
                    SendToDelta("IsDelta");
                    Thread.Sleep(100);
                    SendToDelta("IsDelta");
                    Thread.Sleep(100);
                    SendToDelta("Position");
                    Thread.Sleep(100);
                }
                catch
                {
                    return;
                }

                if (DeltaXPort.IsOpen == false)
                    return;

                btConnect.Text = "Disconnect";
                lbConnectionState.Text = "Connected!";

                               
            }
            else
            {
                btConnect.Text = "Connect";
                lbConnectionState.Text = "Not Connected!";
                DeltaXPort.Close();
            }
                      
        }

        private void SendDataFromTerminal(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendToDelta(tbTransmit.Text);
                tbTransmit.Text = "";
            }            
        }

        void SendToDelta(String cmd)
        {
            if (DeltaXPort.IsOpen == false)
                return;

            TransmitedData = cmd;
            DeltaXPort.WriteLine(TransmitedData);
        }

        private void MoveDeltaX(object sender, EventArgs e)
        {
            Button senderButotn = (Button)sender;
            if (senderButotn.Text == "U")
            {
                float value = float.Parse(tbZ.Text) + float.Parse(cbDivision.Text);
                tbZ.Text = value.ToString();
                SendToDelta("G01 Z" + tbZ.Text);
            }
            if (senderButotn.Text == "D")
            {
                float value = float.Parse(tbZ.Text) - float.Parse(cbDivision.Text);
                tbZ.Text = value.ToString();
                SendToDelta("G01 Z" + tbZ.Text);
            }
            if (senderButotn.Text == "F")
            {
                float value = float.Parse(tbY.Text) + float.Parse(cbDivision.Text);
                tbY.Text = value.ToString();
                SendToDelta("G01 Y" + tbY.Text);
            }
            if (senderButotn.Text == "B")
            {
                float value = float.Parse(tbY.Text) - float.Parse(cbDivision.Text);
                tbY.Text = value.ToString();
                SendToDelta("G01 Y" + tbY.Text);
            }
            if (senderButotn.Text == "L")
            {
                float value = float.Parse(tbX.Text) - float.Parse(cbDivision.Text);
                tbX.Text = value.ToString();
                SendToDelta("G01 X" + tbX.Text);
            }
            if (senderButotn.Text == "R")
            {
                float value = float.Parse(tbX.Text) + float.Parse(cbDivision.Text);
                tbX.Text = value.ToString();
                SendToDelta("G01 X" + tbX.Text);
            }
        }

        private void GoHome(object sender, EventArgs e)
        {
            SendToDelta("G28");
            SendToDelta("Position");
        }

        private void UpdateDeltaXValue(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TextBox senderTextbox = (TextBox)sender;

                if (senderTextbox == tbVel)
                {
                    SendToDelta("G01 F" + tbVel.Text);
                }
                if (senderTextbox == tbAccel)
                {
                    SendToDelta("M204 A" + tbAccel.Text);
                }
                if (senderTextbox == tbX || senderTextbox == tbY || senderTextbox == tbZ || senderTextbox == tbW)
                {
                    SendToDelta(String.Format("G01 X{0} Y{1} Z{2} W{3}", tbX.Text, tbY.Text, tbZ.Text, tbW.Text));
                }
            }
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            string[] lines = tbGcodeEditor.Text.Split('\n');
            GcodeCommands.Clear();

            foreach(string line in lines)
            {
                string gcodeLine = line.Replace("\r", "");
                if (gcodeLine != "")
                {
                    GcodeCommands.Add(gcodeLine);
                }
            }

            TransmitGcodeLineInGcodeEditor();
        }

        void TransmitGcodeLineInGcodeEditor()
        {
            if (GcodeCommands.Count > 0)
            {
                string gcode = GcodeCommands.First();
                UpdateDeltaXPositionToGUI(gcode);

                SendToDelta(gcode);
                GcodeCommands.RemoveAt(0);
            }
        }

        void UpdateDeltaXPositionToGUI(String cmd)
        {
            if (cmd.IndexOf("G28") > -1)
            {
                tbX.Text = XHome;
                tbY.Text = YHome;
                tbZ.Text = ZHome;
            }

            if (cmd.IndexOf("G01") == -1)
                return;

            tbX.Text = GetValueFromGcode(cmd, "X", tbX.Text);
            tbY.Text = GetValueFromGcode(cmd, "Y", tbY.Text);
            tbZ.Text = GetValueFromGcode(cmd, "Z", tbZ.Text);
            tbW.Text = GetValueFromGcode(cmd, "W", tbW.Text);
        }

        string GetValueFromGcode(string gcode, string key, string defaultValue)
        {
            int pos = gcode.IndexOf(key);
            string value = "";

            if (pos > -1)
            {
                gcode.Replace("\r", "");
                gcode.Replace("\n", "");

                for (int i = pos + 1; i < gcode.Length; i++)
                {
                    if (gcode[i] == ' ')
                        break;
                    value += gcode[i];
                }
            }
            else
            {
                return defaultValue;
            }

            return value;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ActivateUnityWindow();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            DeactivateUnityWindow();
        }

        private void btOpenROS_Click(object sender, EventArgs e)
        {
            if (IsROSRunning == false)
            {
                RunEmbedWindow(Directory.GetCurrentDirectory() + "/ROS/Delta X Ros.exe");
            }
            else
            {
                DeactivateUnityWindow();
            }
        }
    }
}
