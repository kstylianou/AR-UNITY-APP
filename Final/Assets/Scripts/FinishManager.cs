//Script to handle the text provided within the "Congradulations" scene 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;

public class FinishManager : MonoBehaviour
{
    public Text hello_text;

    void Start()
    {
        hello_text.text = "Well Done " + AuthManager.GetUsername + "!!!";
    }
}
