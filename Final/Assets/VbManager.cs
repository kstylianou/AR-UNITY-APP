using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbManager : MonoBehaviour
{

    public GameObject vbBtnObj;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Pressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
