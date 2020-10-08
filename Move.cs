using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform camera;
    public CharacterController movecontrol;
    public float playerspeed = 4f;
    public float smoothtime = 0.1f;
    float smoothvel;

    void Start()
    {
        movecontrol = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(hori, 0.0f, vert).normalized;
        if (dir.magnitude >= 0.1)
        {
            float tarA = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float smooth = Mathf.SmoothDampAngle(transform.eulerAngles.y, tarA, ref smoothvel, smoothtime);
            transform.rotation = Quaternion.Euler(0f, smooth, 0f);
            Vector3 movedir = Quaternion.Euler(0f, tarA, 0f) * Vector3.forward;
            movecontrol.Move(movedir * playerspeed * Time.deltaTime);
        }
    }
}
