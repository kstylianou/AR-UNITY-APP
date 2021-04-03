using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ShapesGame : MonoBehaviour
{
    public int state = 0;

    public GameObject vb_triangle;
    public Text select_text;

    private bool triangle_pressed = false;

    void Start()
    {
        vb_triangle = GameObject.Find("vb_triangle");
        vb_triangle.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(triangleButtonPressed);
        vb_triangle.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(triangleButtonReleased);
    }

    public void triangleButtonPressed(VirtualButtonBehaviour vb)
    {
        triangle_pressed = true;
    }

    public void triangleButtonReleased(VirtualButtonBehaviour vb)
    {
        triangle_pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case 0:
                select_text.text = "Select Triangle";
                if (triangle_pressed)
                {
                    state = 1;
                }
                break;

            case 1:
                select_text.text = "Select Square";
                break;
                
        }

        Debug.Log(state);
    }
}
