using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Typewritter : MonoBehaviour
{
    public TextMeshProUGUI Tekssoal;
    public TextMeshProUGUI inputText;
    public TextMeshProUGUI italicText;

    private string outputString = null;
    private int i = -1;
    private bool done;
    private bool changed;

    public float charPerSec = 10;

    private void Awake()
    {
        BeginTypewr(inputText.text);
    }

    // Update is called once per frame
    private void Update()
    {
        //if (!done)
        //{
        //    Tekssoal.text = Typewrite(inputText.text);
        //}
        //else
        //{
        //    if (!changed)
        //    {
        //        Tekssoal.text = italicText.text;
        //        changed = true;
        //    }
        //}
        if (done)
        {
            if(!changed)
            {
                Tekssoal.text = italicText.text;
                changed = true;
            }
        }
    }

    private string Typewrite(string text)
    {
        i++;
        char [] characters = text.ToCharArray();
        outputString = outputString + characters[i].ToString();
        if(i == (characters.Length - 1))
        {
            done = true;
        }
        return outputString;
    }

    private void BeginTypewr(string text)
    {
        char[] character = text.ToCharArray();
        StartCoroutine(Type(character, charPerSec));
    }

    private IEnumerator Type(char[] chars, float charPerSec)
    {
        i++;
        outputString = outputString + chars[i].ToString();
        Tekssoal.text = outputString;
        yield return new WaitForSeconds(1 / charPerSec);
        if(i == chars.Length -1 )
        {
            done = true;
        }
        else
        {
            StartCoroutine(Type(chars, charPerSec));
        }
    }
}
