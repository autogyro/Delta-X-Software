namespace Delta_X_Software.Net
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnect = new System.Windows.Forms.Button();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.tbGcodeEditor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btExecute = new System.Windows.Forms.Button();
            this.tbReceive = new System.Windows.Forms.TextBox();
            this.tbTransmit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDivision = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbAccel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btHome = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lbAccel = new System.Windows.Forms.Label();
            this.tbVel = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPortList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbConnectionState = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbW = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnDeltaXROS = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbDebug = new System.Windows.Forms.Label();
            this.btOpenROS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(18, 31);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(128, 42);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(83, 87);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(128, 24);
            this.cbBaudrate.TabIndex = 1;
            this.cbBaudrate.Text = "115200";
            // 
            // tbGcodeEditor
            // 
            this.tbGcodeEditor.Location = new System.Drawing.Point(6, 41);
            this.tbGcodeEditor.Multiline = true;
            this.tbGcodeEditor.Name = "tbGcodeEditor";
            this.tbGcodeEditor.Size = new System.Drawing.Size(373, 511);
            this.tbGcodeEditor.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btExecute);
            this.groupBox1.Controls.Add(this.tbGcodeEditor);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 613);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "G-code Editor";
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(245, 558);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(134, 48);
            this.btExecute.TabIndex = 3;
            this.btExecute.Text = "Execute";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // tbReceive
            // 
            this.tbReceive.Location = new System.Drawing.Point(121, 28);
            this.tbReceive.Multiline = true;
            this.tbReceive.Name = "tbReceive";
            this.tbReceive.ReadOnly = true;
            this.tbReceive.Size = new System.Drawing.Size(291, 77);
            this.tbReceive.TabIndex = 4;
            // 
            // tbTransmit
            // 
            this.tbTransmit.Location = new System.Drawing.Point(121, 111);
            this.tbTransmit.Name = "tbTransmit";
            this.tbTransmit.Size = new System.Drawing.Size(291, 22);
            this.tbTransmit.TabIndex = 4;
            this.tbTransmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendDataFromTerminal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Receive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transmit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "F";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MoveDeltaX);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MoveDeltaX);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "L";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MoveDeltaX);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 0;
            this.button4.Text = "R";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MoveDeltaX);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 42);
            this.button5.TabIndex = 0;
            this.button5.Text = "U";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MoveDeltaX);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(37, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 42);
            this.button6.TabIndex = 0;
            this.button6.Text = "D";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.MoveDeltaX);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbReceive);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbTransmit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(966, 476);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 153);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminal";
            // 
            // cbDivision
            // 
            this.cbDivision.FormattingEnabled = true;
            this.cbDivision.Items.AddRange(new object[] {
            "0.5",
            "1",
            "5",
            "10",
            "20"});
            this.cbDivision.Location = new System.Drawing.Point(109, 70);
            this.cbDivision.Name = "cbDivision";
            this.cbDivision.Size = new System.Drawing.Size(69, 24);
            this.cbDivision.TabIndex = 7;
            this.cbDivision.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Division";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "mm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbAccel);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.cbDivision);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btHome);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lbAccel);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.tbVel);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(965, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 242);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Moving";
            // 
            // tbAccel
            // 
            this.tbAccel.Location = new System.Drawing.Point(264, 21);
            this.tbAccel.Name = "tbAccel";
            this.tbAccel.Size = new System.Drawing.Size(67, 22);
            this.tbAccel.TabIndex = 8;
            this.tbAccel.Text = "1200";
            this.tbAccel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateDeltaXValue);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(179, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "mm/s";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(86, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "V";
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(264, 60);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(105, 42);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.GoHome);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(337, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "mm/s2";
            // 
            // lbAccel
            // 
            this.lbAccel.AutoSize = true;
            this.lbAccel.Location = new System.Drawing.Point(241, 21);
            this.lbAccel.Name = "lbAccel";
            this.lbAccel.Size = new System.Drawing.Size(17, 17);
            this.lbAccel.TabIndex = 5;
            this.lbAccel.Text = "A";
            // 
            // tbVel
            // 
            this.tbVel.Location = new System.Drawing.Point(109, 21);
            this.tbVel.Name = "tbVel";
            this.tbVel.Size = new System.Drawing.Size(64, 22);
            this.tbVel.TabIndex = 8;
            this.tbVel.Text = "200";
            this.tbVel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateDeltaXValue);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPortList);
            this.groupBox4.Controls.Add(this.cbBaudrate);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(1166, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 133);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serial Port";
            // 
            // cbPortList
            // 
            this.cbPortList.FormattingEnabled = true;
            this.cbPortList.Location = new System.Drawing.Point(83, 53);
            this.cbPortList.Name = "cbPortList";
            this.cbPortList.Size = new System.Drawing.Size(128, 24);
            this.cbPortList.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "COM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Baudrate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "reload";
            this.label7.Click += new System.EventHandler(this.GetAvailableSerialPorts);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "State:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btConnect);
            this.groupBox5.Controls.Add(this.lbConnectionState);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(966, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 132);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delta X Connection";
            // 
            // lbConnectionState
            // 
            this.lbConnectionState.AutoSize = true;
            this.lbConnectionState.Location = new System.Drawing.Point(69, 93);
            this.lbConnectionState.Name = "lbConnectionState";
            this.lbConnectionState.Size = new System.Drawing.Size(100, 17);
            this.lbConnectionState.TabIndex = 5;
            this.lbConnectionState.Text = "Not connected";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(47, 30);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(64, 22);
            this.tbX.TabIndex = 8;
            this.tbX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateDeltaXValue);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Y";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(140, 30);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(67, 22);
            this.tbY.TabIndex = 8;
            this.tbY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateDeltaXValue);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Z";
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(236, 30);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(67, 22);
            this.tbZ.TabIndex = 8;
            this.tbZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateDeltaXValue);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbY);
            this.groupBox6.Controls.Add(this.tbW);
            this.groupBox6.Controls.Add(this.tbZ);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.tbX);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(966, 153);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(427, 65);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Position";
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(332, 30);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(79, 22);
            this.tbW.TabIndex = 8;
            this.tbW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateDeltaXValue);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "W";
            // 
            // pnDeltaXROS
            // 
            this.pnDeltaXROS.Location = new System.Drawing.Point(121, 41);
            this.pnDeltaXROS.Name = "pnDeltaXROS";
            this.pnDeltaXROS.Size = new System.Drawing.Size(400, 300);
            this.pnDeltaXROS.TabIndex = 12;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btOpenROS);
            this.groupBox7.Controls.Add(this.lbDebug);
            this.groupBox7.Controls.Add(this.pnDeltaXROS);
            this.groupBox7.Location = new System.Drawing.Point(412, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(536, 613);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ROS";
            // 
            // lbDebug
            // 
            this.lbDebug.Location = new System.Drawing.Point(9, 571);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(521, 35);
            this.lbDebug.TabIndex = 13;
            this.lbDebug.Text = "Debug: ";
            // 
            // btOpenROS
            // 
            this.btOpenROS.Location = new System.Drawing.Point(12, 41);
            this.btOpenROS.Name = "btOpenROS";
            this.btOpenROS.Size = new System.Drawing.Size(103, 35);
            this.btOpenROS.TabIndex = 14;
            this.btOpenROS.Text = "Open ROS";
            this.btOpenROS.UseVisualStyleBackColor = true;
            this.btOpenROS.Click += new System.EventHandler(this.btOpenROS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 637);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Delta X Software .Net";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.TextBox tbGcodeEditor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.TextBox tbReceive;
        private System.Windows.Forms.TextBox tbTransmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDivision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbPortList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbConnectionState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbW;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.TextBox tbAccel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbAccel;
        private System.Windows.Forms.TextBox tbVel;
        private System.Windows.Forms.Panel pnDeltaXROS;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbDebug;
        private System.Windows.Forms.Button btOpenROS;
    }
}

