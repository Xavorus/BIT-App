using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    //Username
    public TextMeshProUGUI DisplayName;
    public TMP_InputField InputName;
    //Mail
    public TextMeshProUGUI DisplayMail;
    public TMP_InputField InputMail;

    // Start is called before the first frame update
    public void Start()
    {
    }

    public void Create_Uname()
    {
        PlayerPrefs.SetString("name", InputName.text);
        Debug.Log("Your name is" + PlayerPrefs.GetString("name"));
    }

    public void Create_Email()
    {
        PlayerPrefs.SetString("mail", InputMail.text);
        Debug.Log("Your mail is" + PlayerPrefs.GetString("mail"));
    }

    public void Create_UID()
    {
        
    }
}
