using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Text;
using UnityEngine.Networking;

public class Controller : MonoBehaviour {
    
    public GameObject MovingPlatform;
    public TCPClient Socket;
    public GameObject GripperL;
    public GameObject GripperR;
    public GameObject Gripper;
    public GameObject SuctionCup;
    public Camera MainCamera;

    Vector3 InitTrianglePosition;
    Vector3 TrianglePosition;
    Vector3 TriangleRelativePosition;
    
    MoveTriangle TriangleScriptObject;
    public float distanceToZHome = 0.065f;
    Vector3 TriangleHomePosition;

    float feedrate = 0.2f;

    string server = "localhost";
    int port = 8844;
    string ip;

    public static Controller instance = null;


    public bool isXFreeze = false;
    public bool isYFreeze = false;
    public bool isZFreeze = false;

    private bool isMoveTriangle = false;
    private Vector3 targetPosition;

    public bool isDeltaX = false;

    void Awake()
    {
        instance = this;
    }
    static public Controller GetInstance()
    {
        if (instance == null)
            instance = new Controller();

        return instance;
    }

    void Start () {
        TriangleScriptObject = MovingPlatform.GetComponent<MoveTriangle>();

        InitTrianglePosition = MovingPlatform.transform.localPosition;

        InitHome();

        SetupClient();
    }

    void Update()
    {
        string request = GetInput();
        ProcessRequest(request);
        UpdateMovingPlatformPosition();
    }

    private void UpdateMovingPlatformPosition()
    {
        if (isMoveTriangle == true)
        {
            MovingPlatform.transform.localPosition = Vector3.MoveTowards(MovingPlatform.transform.localPosition, targetPosition, feedrate * Time.deltaTime);
            if (MovingPlatform.transform.localPosition == targetPosition)
            {
                isMoveTriangle = false;
                SetOutput("Ok");
            }
        }        
    }

    private void SetupClient()
    {
        if (File.Exists("ip.txt"))
        {
            using (StreamReader reader = new StreamReader("ip.txt"))
            {
                string inputText = reader.ReadToEnd();
                reader.Close();

                Debug.Log(inputText);

                server = inputText.Substring(0, inputText.IndexOf(":"));
                port = int.Parse(inputText.Substring(inputText.IndexOf(":") + 1));

                Debug.Log(server);
                Debug.Log(port);
            }
        }        

        Socket.ConnectToTcpServer(server, port);
    } 

    void InitHome()
    {
        TrianglePosition = MovingPlatform.transform.localPosition;
        TriangleRelativePosition = Vector3.zero;

        TrianglePosition.z += distanceToZHome;
        TriangleHomePosition = TrianglePosition;

        isMoveTriangle = true;
        targetPosition = TrianglePosition;
    }

    void ProcessRequest(string request)
    {
        if (request == "")
        {
            return;
        }

        //Debug.Log(request);

        string[] words = request.Split(' ');

        try
        {
            if (words[0] == "move")
            {
                if (words[1] == "triangle")
                {
                    float x = TriangleRelativePosition.x;
                    float y = TriangleRelativePosition.y;
                    float z = TriangleRelativePosition.z;

                    for (int i = 2; i < words.Length; i++)
                    {
                        if (words[i] == "x")
                        {
                            x = float.Parse(words[i + 1]);
                            ++i;
                        }
                        if (words[i] == "y")
                        {
                            y = float.Parse(words[i + 1]);
                            ++i;
                        }
                        if (words[i] == "z")
                        {
                            z = float.Parse(words[i + 1]);
                            ++i;
                        }

                        if (words[i] == "f")
                        {
                            feedrate = float.Parse(words[i + 1]) / 1000;
                            Debug.Log(feedrate);
                            ++i;
                        }
                    }
                    
                    G01(x, y, z);
                }
            }

            if (words[0] == "update")
            {
                if (words[1] == "object")
                {
                    Debug.Log(request);
                    ObjectManager.GetInstance().UpdateObject(words[2], new Vector3(float.Parse(words[3]), float.Parse(words[4]), float.Parse(words[5])), new Vector3(float.Parse(words[6]), float.Parse(words[7]), float.Parse(words[8])));
                }
                if (words[1] == "end_effector")
                {
                    ChangeEndEffector(int.Parse(words[2]));
                }
                if (words[1] == "camera_position")
                {
                    ChangeCameraPosition(int.Parse(words[2]));
                }
            }

            if (words[0] == "delete")
            {
                ObjectManager.GetInstance().DeleteObject(words[1]);
            }

            if (words[0] == "gcode")
            {
                if (words[1].ToLower() == "m03" || words[1].ToLower() == "m3")
                {
                    Debug.Log(request);
                    M03();
                }
                if (words[1].ToLower() == "m05" || words[1].ToLower() == "m5")
                {
                    Debug.Log(request);
                    M05();
                }
                if (words[1].ToLower() == "g28")
                {
                    G28();
                }

            }
            if (words[0] == "deltax")
            {
                isDeltaX = true;
                
                InvokeRepeating("CheckDeltaXIsAlive", 0, 5);
                Debug.Log("deltax");
            }
        }
        catch (Exception e)
        {

        }
    }

    void CheckDeltaXIsAlive()
    {
        try
        {
            if (!SetOutput("ros"))
            {
                CancelInvoke();
                Debug.Log("Exit");
                Application.Quit();
            }
        }
        catch (Exception e)
        {
            CancelInvoke();
            Debug.Log("Exit");
            Application.Quit();
        }
    }

    public void G01(float x, float y, float z)
    {
        TriangleRelativePosition = new Vector3(x, y, z);
        TrianglePosition = MovingPlatform.transform.localPosition;

        TrianglePosition.x = TriangleHomePosition.x + x / 1000;
        TrianglePosition.y = TriangleHomePosition.y + y / 1000;
        TrianglePosition.z = TriangleHomePosition.z + z / 1000;

        isMoveTriangle = true;
        targetPosition = TrianglePosition;
    }

    public void G28()
    {
        TriangleRelativePosition = Vector3.zero;
        TrianglePosition = TriangleHomePosition;

        isMoveTriangle = true;
        targetPosition = TrianglePosition;
    }

    public void M03()
    {
        SetGripperAngle(0);
    }

    public void M05()
    {
        SetGripperAngle(45);
    }

    public void SetGripperAngle(float a)
    {
        GripperL.transform.localEulerAngles = new Vector3(-a, 0, 0);
        GripperR.transform.localEulerAngles = new Vector3(a, 0, 0);
    }

    public void LogRelativePosition(Vector3 pointPosition)
    {
        Vector3 relative;
        relative.x = (pointPosition.x - TriangleHomePosition.x) * 1000;
        relative.y = (pointPosition.y - TriangleHomePosition.y) * 1000;
        relative.z = (pointPosition.z - TriangleHomePosition.z) * 1000;

        SetOutput("x " + Math.Round(relative.x, 1) + " y " + Math.Round(relative.y, 1) + " z " + Math.Round(relative.z, 1));
    }

    bool SetOutput(string msg)
    {
        return Socket.SendMsg(msg + "\n");
    }

    string GetInput()
    {
        return Socket.GetMessage();
    }


    public void FreezeX(bool value)
    {
        isXFreeze = value;
    }

    public void FreezeY(bool value)
    {
        isYFreeze = value;
    }

    public void FreezeZ(bool value)
    {
        isZFreeze = value;
    }

    public void ChangeEndEffector(int value)
    {
        if (value == 0)
        {
            Gripper.SetActive(false);
            SuctionCup.SetActive(true);
        }
        if (value == 1)
        {
            Gripper.SetActive(true);
            SuctionCup.SetActive(false);
        }
        if (value == 2)
        {
            Gripper.SetActive(false);
            SuctionCup.SetActive(false);
        }
    }

    public void ChangeCameraPosition(int value)
    {
        if (value == 0)
        {
            Camera.main.transform.position = new Vector3(0, 1, -17);
            Camera.main.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (value == 1)
        {
            Camera.main.transform.position = new Vector3(5.5f, 5.5f, -15);
            Camera.main.transform.eulerAngles = new Vector3(18, -24, 0);
        }
        if (value == 2)
        {
            Camera.main.transform.position = new Vector3(18, 1, -1);
            Camera.main.transform.eulerAngles = new Vector3(0, -90, 0);
        }
    }
}
