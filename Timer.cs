using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
public class Timer : MonoBehaviour
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

    private static extern int GetNumCheckpoint();

    float currTime = 0.0f;
    double round = 0.0;
    Text timer;
    public void SaveTime(float ctime)
    {
        SaveCheckpointTime(ctime);
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Text>();
        timer.text = "Time: 0.0s";
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        round = System.Math.Round(currTime, 2);
        timer.text = "Time: " + round + "s";
    }

    void OnDestroy()
    {
        ResetLogger();
    }
}