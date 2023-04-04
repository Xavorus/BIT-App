using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeManager : MonoBehaviour
{
    public Toggle toggle;
    public Dropdown dropdown;
    public GameObject lightMode;
    public GameObject darkMode;

    private bool isDarkMode = false;

    void Start()
    {
        if (PlayerPrefs.GetInt("isDarkMode") == 1)
        {
            isDarkMode = true;
            toggle.isOn = true;
        }

        SetMode();
    }

    public void ToggleMode()
    {
        isDarkMode = !isDarkMode;
        SetMode();

        PlayerPrefs.SetInt("isDarkMode", isDarkMode ? 1 : 0);
        PlayerPrefs.Save();
    }

    private void SetMode()
    {
        if (isDarkMode)
        {
            darkMode.SetActive(true);
            lightMode.SetActive(false);
        }
        else
        {
            darkMode.SetActive(false);
            lightMode.SetActive(true);
        }
    }
}
