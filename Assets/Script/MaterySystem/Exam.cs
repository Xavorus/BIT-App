using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exam : MonoBehaviour
{
    //Progress Bar
    public GameObject Progress10;
    public GameObject Progress20;
    public GameObject Progress30;
    public GameObject Progress40;
    public GameObject Progress50;
    public GameObject Progress60;
    public GameObject Progress70;
    public GameObject Progress80;
    public GameObject Progress90;
    public GameObject Progress100;

    //Next Button
    public GameObject NextBtn1;
    public GameObject NextBtn2;
    public GameObject NextBtn3;
    public GameObject NextBtn4;
    public GameObject NextBtn5;
    public GameObject NextBtn6;
    public GameObject NextBtn7;
    public GameObject NextBtn8;
    public GameObject NextBtn9;
    public GameObject NextBtn10;

    //1
    public GameObject Exam1;
    //2
    public GameObject Exam2;
    //3
    public GameObject Exam3;
    //4
    public GameObject Exam4;
    //5
    public GameObject Exam5;
    //6
    public GameObject Exam6;
    //7
    public GameObject Exam7;
    //8
    public GameObject Exam8;
    //9
    public GameObject Exam9;
    //10
    public GameObject Exam10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ActiveEX2()
    {
        //Progress
        Progress10.SetActive(false);
        Progress20.SetActive(true);
        //Next Button
        NextBtn1.SetActive(false);
        NextBtn2.SetActive(true);
        //Exam Scene
        Exam1.SetActive(false);
        Exam2.SetActive(true);
        //Debug
        Debug.Log("2.You Did it! keep it up!");
    }
    public void ActiveEX3()
    {
        //Progress
        Progress20.SetActive(false);
        Progress30.SetActive(true);
        //Next Button
        NextBtn2.SetActive(false);
        NextBtn3.SetActive(true);
        //Exam Scene
        Exam2.SetActive(false);
        Exam3.SetActive(true);
        //Debug
        Debug.Log("3.You Did it! keep it up!");
    }
    public void ActiveEX4()
    {
        //Progress
        Progress30.SetActive(false);
        Progress40.SetActive(true);
        //Next Button
        NextBtn3.SetActive(false);
        NextBtn4.SetActive(true);
        //Exam Scene
        Exam3.SetActive(false);
        Exam4.SetActive(true);
        //Debug
        Debug.Log("4.You Did it! keep it up!");
    }
    public void ActiveEX5()
    {
        //Progress
        Progress40.SetActive(false);
        Progress50.SetActive(true);
        //Next Button
        NextBtn4.SetActive(false);
        NextBtn5.SetActive(true);
        //Exam Scene
        Exam4.SetActive(false);
        Exam5.SetActive(true);
        //Debug
        Debug.Log("5.You Did it! keep it up!");
    }
    public void ActiveEX6()
    {
        //Progress
        Progress50.SetActive(false);
        Progress60.SetActive(true);
        //Next Button
        NextBtn5.SetActive(false);
        NextBtn6.SetActive(true);
        //Exam Scene
        Exam5.SetActive(false);
        Exam6.SetActive(true);
        //Debug
        Debug.Log("6.You Did it! keep it up!");
    }
    public void ActiveEX7()
    {
        //Progress
        Progress60.SetActive(false);
        Progress70.SetActive(true);
        //Next Button
        NextBtn6.SetActive(false);
        NextBtn7.SetActive(true);
        //Exam Scene
        Exam6.SetActive(false);
        Exam7.SetActive(true);
        //Debug
        Debug.Log("7.You Did it! keep it up!");
    }
    public void ActiveEX8()
    {
        //Progress
        Progress70.SetActive(false);
        Progress80.SetActive(true);
        //Next Button
        NextBtn7.SetActive(false);
        NextBtn8.SetActive(true);
        //Exam Scene
        Exam7.SetActive(false);
        Exam8.SetActive(true);
        //Debug
        Debug.Log("8.You Did it! keep it up!");
    }
    public void ActiveEX9()
    {
        //Progress
        Progress80.SetActive(false);
        Progress90.SetActive(true);
        //Next Button
        NextBtn8.SetActive(false);
        NextBtn9.SetActive(true);
        //Exam Scene
        Exam8.SetActive(false);
        Exam9.SetActive(true);
        //Debug
        Debug.Log("9.You Did it! keep it up!");
    }
    public void ActiveEX10()
    {
        //Progress
        Progress90.SetActive(false);
        Progress100.SetActive(true);
        //Next Button
        NextBtn9.SetActive(false);
        NextBtn10.SetActive(true);
        //Exam Scene
        Exam9.SetActive(false);
        Exam10.SetActive(true);
        //Debug
        Debug.Log("10.You Did it! keep it up!");
    }

    public void back_to_Learn_Topics_Prolog()
    {
        SceneManager.LoadScene("Learn_Prolog");
    }

    public void back_to_Learn_Topics_Hardware()
    {
        SceneManager.LoadScene("Learn_Hardware");
    }

    public void back_to_Learn_Topics_Software()
    {
        SceneManager.LoadScene("Learn_Software");
    }

    public void back_to_Learn_Topics_Network()
    {
        SceneManager.LoadScene("Learn_Network");
    }

    public void back_to_Learn_Topics_Website()
    {
        SceneManager.LoadScene("Learn_Network");
    }

    public void back_to_Learn_Topics_Languages()
    {
        SceneManager.LoadScene("Learn_HTML");
    }

    public void back_to_Learn_Topics_HTML()
    {
        SceneManager.LoadScene("Learn_Hardware");
    }

    public void back_to_Learn_Topics_CSS()
    {
        SceneManager.LoadScene("Learn_Software");
    }
    //This is only can be open after finish 4 Topics
}
