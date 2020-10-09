﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEditor;
using System.IO;
public class CheckpointManager : MonoBehaviour
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

    public GameObject currcheckpoint;
    CharacterController ferret;
    float currTime = 0.0f;
    public int checkpointnumber;

    void Start()
    {
        ferret = FindObjectOfType<CharacterController>();
    }

    void Update()
    {
        currTime += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(currcheckpoint.name + " hit!");
            SaveCheckpointTime(currTime);
            Debug.Log(GetCheckpointTime(checkpointnumber));
        }
    }

    //void OnDestroy()
    //{
    //    ResetLogger();
    //}
}
