using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestScene_Script : MonoBehaviour
{
    //1
    public GameObject Tipe1;
    //2
    public GameObject Tipe2;
    //3
    public GameObject Tipe3;
    //4
    public GameObject Testu1;
    //5
    public GameObject Testu2;
    
    // Start is called before the first frame update
    void Start()
    {
        Tipe2.SetActive(false);
        Tipe3.SetActive(false);
        Testu1.SetActive(false);
        Testu2.SetActive(false);
    }
    
    public void Types2()
    {
        Tipe1.SetActive(false);
        Tipe2.SetActive(true);
        Debug.Log("Type 1 Inactive");
    }

    public void Types3()
    {
        Tipe2.SetActive(false);
        Tipe3.SetActive(true);
        Debug.Log("Type 2 Inactive");
    }

    public void Test1()
    {
        Tipe3.SetActive(false);
        Testu1.SetActive(true);
        Debug.Log("Type 3 Inactive");
    }

    public void Test2()
    {
        Testu1.SetActive(false);
        Testu2.SetActive(true);
        Debug.Log("Test 1 Inactive");
    }

    public void Types1()
    {
        Testu2.SetActive(false);
        Tipe1.SetActive(true);
        Debug.Log("Test 2 Inactive");
    }

    public void BacktoTopics()
    {
        SceneManager.LoadScene("Learn_TechBasic");
        Debug.Log("Back to Topics");
    }
}
