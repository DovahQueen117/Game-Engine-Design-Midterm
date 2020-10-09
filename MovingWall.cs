using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public Transform wall;
    Vector3 newpos = new Vector3(0, -100, 0);
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            wall.SetPositionAndRotation(newpos, Quaternion.EulerAngles(Vector3.zero));
        }
    }
}
