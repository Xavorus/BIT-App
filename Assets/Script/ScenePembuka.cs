using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePembuka : MonoBehaviour
{
    public GameObject Banner1;
    public GameObject Banner2;
    public GameObject Banner3;
    public GameObject Banner4;
    public GameObject Banner5;
    public GameObject Banner6;
    public GameObject Banner7;

    //Skip
    public void SkipAllPage()
    {
        SceneManager.LoadScene("Learn");
        Debug.Log("Skiped the Open Scene");
    }

    //To Learn
    public void Membuka_Learn()
    {
        SceneManager.LoadScene("Learn");
        Debug.Log("Membuka Learn");
    }

    //Next
    public void NextTutorial2()
    {
        Banner1.SetActive(false);
        Banner2.SetActive(true);
    }

    public void NextTutorial3()
    {
        Banner2.SetActive(false);
        Banner3.SetActive(true);
    }

    public void NextTutorial4()
    {
        Banner3.SetActive(false);
        Banner4.SetActive(true);
    }

    public void NextTutorial5()
    {
        Banner4.SetActive(false);
        Banner5.SetActive(true);
    }

    public void NextTutorial6()
    {
        Banner5.SetActive(false);
        Banner6.SetActive(true);
    }

    public void NextTutorial7()
    {
        Banner6.SetActive(false);
        Banner7.SetActive(true);
    }
}
