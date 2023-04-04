using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Experience : MonoBehaviour
{
    //Main XP
    public int ProgressPoint;
    public TextMeshProUGUI ProgressionText;
    public Image ProgressTopic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProgressionText.text = ProgressPoint.ToString();
    }

    public void IncreasedLevel()
    {
        ProgressPoint++;
    }
}
