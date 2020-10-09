using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    const string DLL_NAME = "EnginesDLLTut";

    public CharacterController movecontrol;
    public float playerspeed = 4f;
    public float smoothtime = 0.1f;
    public float vel;
    public GameObject player;
    public GameObject currcheckpoint;

    void Start()
    {
        movecontrol = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        //changing movement since the smoothing was messing with the gravity
        //movement and gravity exist, even if it's basically drunk ferret sim now
        if (movecontrol.isGrounded)
        {
            vel = -9.8f * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                vel = 4.0f;
            }
        }
        if (vel <= -30)
        {
            //This line just kept having the ferret stop rather than go to the checkpoint, so I guess if you fall off you just restart
            //player.transform.position = currcheckpoint.transform.position;
            SceneManager.LoadScene("PlayScene");
        }
        else
        {
            vel -= 9.8f * Time.deltaTime;
        }
        Vector3 move = new Vector3(hori, vel, vert).normalized;
        player.transform.rotation = Quaternion.RotateTowards(player.transform.rotation, Quaternion.LookRotation(move), 45 * Time.deltaTime);
        movecontrol.Move(move * playerspeed * Time.deltaTime);
    }
}
