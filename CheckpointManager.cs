using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

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

    void Start()
    {
        ferret = FindObjectOfType<CharacterController>();
    }

    public void Respawn()
    {
        Debug.Log("Player Respawn");
        ferret.transform.position = currcheckpoint.transform.position;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Respawn();
        }
    }
}
