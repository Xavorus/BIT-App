using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.Localization.Settings;

public class LocalSelector : MonoBehaviour
{
    private void Start()
    {
        int ID = PlayerPrefs.GetInt("LocalKey", 0);
    }

    private bool active = false;

    public void Change(int _localeID)
    {
        if (active == true)
            return;
        StartCoroutine(SetLocale(_localeID));
    }

    IEnumerator SetLocale(int _localID)
    {
        active = true; 
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localID];
        active = false;
    }
}
