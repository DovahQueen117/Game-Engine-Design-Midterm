using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void newscene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
