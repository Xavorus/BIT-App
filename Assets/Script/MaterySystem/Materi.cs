using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Materi : MonoBehaviour
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
    public GameObject Matery1;
    //2
    public GameObject Matery2;
    //3
    public GameObject Matery3;
    //4
    public GameObject Matery4;
    //5
    public GameObject Matery5;
    //6
    public GameObject Matery6;
    //7
    public GameObject Matery7;
    //8
    public GameObject Matery8;
    //9
    public GameObject Matery9;
    //10
    public GameObject Matery10;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    //Learn Topics Tech Basic
    public void ActiveM2()
    {
        //Progress
        Progress10.SetActive(false);
        Progress20.SetActive(true);
        //Next Button
        NextBtn1.SetActive(false);
        NextBtn2.SetActive(true);
        //Matery Scene
        Matery1.SetActive(false);
        Matery2.SetActive(true);
        //Debug
        Debug.Log("1.Matery 1 Solved!");
    }

    public void ActiveM3()
    {
        //Progress
        Progress20.SetActive(false);
        Progress30.SetActive(true);
        //Next Button
        NextBtn2.SetActive(false);
        NextBtn3.SetActive(true);
        //Matery Scene
        Matery2.SetActive(false);
        Matery3.SetActive(true);
        //Debug
        Debug.Log("2.Matery 2 Solved!");
    }

    public void ActiveM4()
    {
        //Progress
        Progress30.SetActive(false);
        Progress40.SetActive(true);
        //Next Button
        NextBtn3.SetActive(false);
        NextBtn4.SetActive(true);
        //Matery Scene
        Matery3.SetActive(false);
        Matery4.SetActive(true);
        //Debug
        Debug.Log("3.Matery 3 Solved!");
    }

    public void ActiveM5()
    {
        //Progress
        Progress40.SetActive(false);
        Progress50.SetActive(true);
        //Next Button
        NextBtn4.SetActive(false);
        NextBtn5.SetActive(true);
        //Matery Scene
        Matery4.SetActive(false);
        Matery5.SetActive(true);
        //Debug
        Debug.Log("4.Matery 4 Solved!");
    }

    public void ActiveM6()
    {
        //Progress
        Progress50.SetActive(false);
        Progress60.SetActive(true);
        //Next Button
        NextBtn5.SetActive(false);
        NextBtn6.SetActive(true);
        //Matery Scene
        Matery5.SetActive(false);
        Matery6.SetActive(true);
        //Debug
        Debug.Log("5.Matery 5 Solved!");
    }

    public void ActiveM7()
    {
        //Progress
        Progress60.SetActive(false);
        Progress70.SetActive(true);
        //Next Button
        NextBtn6.SetActive(false);
        NextBtn7.SetActive(true);
        //Matery Scene
        Matery6.SetActive(false);
        Matery7.SetActive(true);
        //Debug
        Debug.Log("6.Matery 6 Solved!");
    }

    public void ActiveM8()
    {
        //Progress
        Progress70.SetActive(false);
        Progress80.SetActive(true);
        //Next Button
        NextBtn7.SetActive(false);
        NextBtn8.SetActive(true);
        //Matery Scene
        Matery7.SetActive(false);
        Matery8.SetActive(true);
        //Debug
        Debug.Log("7.Matery 7 Solved!");
    }

    public void ActiveM9()
    {
        //Progress
        Progress80.SetActive(false);
        Progress90.SetActive(true);
        //Next Button
        NextBtn8.SetActive(false);
        NextBtn9.SetActive(true);
        //Matery Scene
        Matery8.SetActive(false);
        Matery9.SetActive(true);
        //Debug
        Debug.Log("8.Matery 8 Solved!");
    }

    public void ActiveM10()
    {
        //Progress
        Progress90.SetActive(false);
        Progress100.SetActive(true);
        //Next Button
        NextBtn9.SetActive(false);
        NextBtn10.SetActive(true);
        //Matery Scene
        Matery9.SetActive(false);
        Matery10.SetActive(true);
        //Debug
        Debug.Log("9.Matery 9 Solved!");
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

    public void back_to_Learn_Topics_Languages()
    {
        SceneManager.LoadScene("Learn_Languages");
    }

    public void back_to_Learn_Topics_HTML()
    {
        SceneManager.LoadScene("Learn_HTML");
    }

    public void back_to_Learn_Topics_CSS()
    {
        SceneManager.LoadScene("Learn_CSS");
    }

    public void back_to_Learn_Topics_Website()
    {
        SceneManager.LoadScene("Learn_Website");
    }
}
