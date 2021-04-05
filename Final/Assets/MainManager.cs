using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;

public class MainManager : MonoBehaviour
{
    public Text hello_text;

    void Start()
    {
        hello_text.text = "Hello " + AuthManager.GetUsername;
    }
}
