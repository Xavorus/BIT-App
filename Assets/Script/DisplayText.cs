using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public TextMeshProUGUI Username;
    public TextMeshProUGUI Usermail;

    void Start()
    {
        Username.text = PlayerPrefs.GetString("name");
        Usermail.text = PlayerPrefs.GetString("mail");
    }
}

