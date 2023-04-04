using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Show_UID : MonoBehaviour
{
    public TextMeshProUGUI TextMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        string password = PlayerPrefs.GetString("UID's");
    }
}
