using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
    const string DLL_NAME = "EnginesDLLTut";

    //methods
    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    //setters
    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    //getters
    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();
    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);
    [DllImport(DLL_NAME)]

    private static extern int GetNumCheckpoints();

    Text checkpointtime;
    public int checkpointnumber;
    float times;
    double round;

    // Start is called before the first frame update
    void Start()
    {
        checkpointtime = GetComponent<Text>();
        checkpointtime.text = ("0.0s");
    }

    // Update is called once per frame
    void Update()
    { 
        //times = GetCheckpointTime(checkpointnumber);
        //round = System.Math.Round(times, 2);
        //checkpointtime.text = (round + "s");
    }

    //void OnDestroy()
    //{
    //    ResetLogger();
    //}
}
