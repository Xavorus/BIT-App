using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("FirstTime"))
        {
            // Scene is being played for the first time
            SceneManager.LoadScene("MyScene");
            PlayerPrefs.SetInt("FirstTime", 1);
        }
        else
        {
            // Scene has already been played before
            // Do nothing or perform any other action
        }
    }
}
