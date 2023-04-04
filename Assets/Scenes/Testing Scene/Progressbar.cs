using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    public float fillAmount = 0.1f;
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        fillAmount = PlayerPrefs.GetFloat("FillAmount", fillAmount);
        _image.fillAmount = fillAmount;
    }

    private void Update()
    {
        _image.fillAmount = fillAmount;
        PlayerPrefs.SetFloat("FillAmount", fillAmount);
    }
}
