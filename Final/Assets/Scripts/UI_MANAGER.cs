using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class UI_MANAGER : MonoBehaviour
{
    public static UI_MANAGER instance;

    // Screen object variables
    public GameObject loginUI;
    public GameObject registerUI;
    public Button RegisterButton;
    public Button LoginButton;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(this);
        }
    }

    public void LoginScreen()
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }

    public void RegisterScreen()
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }

    void Start()
    {
        Button Registerbtn = RegisterButton.GetComponent<Button>();
        Button LoginBtn = LoginButton.GetComponent<Button>();

        Registerbtn.onClick.AddListener(() => RegisterScreen());
        LoginBtn.onClick.AddListener(() => LoginScreen());
    }
}
