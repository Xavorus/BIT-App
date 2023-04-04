using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBars : MonoBehaviour
{
    public Scrollbar Bars;

    // Start is called before the first frame update
    void Start()
    {
        Bars.size = 0.35f; // Set the size of the handle to 50% of the track
        Bars.value = 1.0f; // Set the initial position of the handle to 25% of the track
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
