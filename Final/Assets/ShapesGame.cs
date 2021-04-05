using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using UnityEngine.SceneManagement;

public class ShapesGame : MonoBehaviour
{
    public int state = 0;

    public GameObject vb_triangle;
    public GameObject vb_square;
    public GameObject vb_circle;
    public GameObject vb_pentagon;

    public Text select_text;

    private bool triangle_pressed = false;
    private bool square_pressed = false;
    private bool circle_pressed = false;
    private bool pentagon_pressed = false;

    void Start()
    {
        // Triangle
       // vb_triangle = GameObject.Find("vb_triangle");
        vb_triangle.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(triangleButtonPressed);
        vb_triangle.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(triangleButtonReleased);

        // Square
       //vb_square = GameObject.Find("vb_square");
        vb_square.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(squareButtonPressed);
        vb_square.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(squareButtonReleased);

        // Circle
       // vb_circle = GameObject.Find("vb_circle");
        vb_circle.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(circleButtonPressed);
        vb_circle.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(circleButtonReleased);

        // Pentagon
        //vb_pentagon = GameObject.Find("vb_pentagon");
        vb_pentagon.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(pentagonButtonPressed);
        vb_pentagon.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(pentagonButtonReleased);
    }

    // Triangle
    public void triangleButtonPressed(VirtualButtonBehaviour vb)
    {
        triangle_pressed = true;
    }

    public void triangleButtonReleased(VirtualButtonBehaviour vb)
    {
        triangle_pressed = false;
    }

    // Square
    public void squareButtonPressed(VirtualButtonBehaviour vb)
    {
        square_pressed = true;
    }

    public void squareButtonReleased(VirtualButtonBehaviour vb)
    {
        square_pressed = false;
    }

    // Circle
    public void circleButtonPressed(VirtualButtonBehaviour vb)
    {
        circle_pressed = true;
    }

    public void circleButtonReleased(VirtualButtonBehaviour vb)
    {
        circle_pressed = false;
    }

    // Pentagon
    public void pentagonButtonPressed(VirtualButtonBehaviour vb)
    {
        pentagon_pressed = true;
    }

    public void pentagonButtonReleased(VirtualButtonBehaviour vb)
    {
        pentagon_pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case 0: // Triangle
                select_text.text = "Select the Triangle";
                if (triangle_pressed)
                    state = 1;
                break;

            case 1: // Square
                select_text.text = "Select the Square";
                if (square_pressed)
                    state = 2;
                break;

            case 2: // Circle
                select_text.text = "Select the Circle";
                if (circle_pressed)
                    state = 3;
                break;

            case 3: // Pentagon
                select_text.text = "Select the Pentagon";
                if (pentagon_pressed)
                    state = 4;
                break;

            case 4: // Finish
                SceneManager.LoadScene("Congradulations");
                break;
        }
    }
}
