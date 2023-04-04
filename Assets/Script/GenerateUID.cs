using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class GenerateUID : MonoBehaviour
{
    private string GenerateUIDuser(int length)
    {
        const string possibleChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            int randomIndex = Random.Range(0, possibleChars.Length);
            password.Append(possibleChars[randomIndex]);
        }

        return password.ToString();
    }
}
