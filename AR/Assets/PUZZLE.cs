using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PUZZLE : MonoBehaviour
{
    public GameObject p_1;
    public GameObject p_2;
    public GameObject p_3;
    public GameObject p_4;

    void Update()
    {
        float p1_Y = p_1.transform.rotation.eulerAngles.y;
        float p2_Y = p_2.transform.rotation.eulerAngles.y;
        float p3_Y = p_3.transform.rotation.eulerAngles.y;
        float p4_Y = p_4.transform.rotation.eulerAngles.y;

        int a = (int)p1_Y;
        int b = (int)p2_Y;

        if (p1_Y == p2_Y)
        {
            SceneManager.LoadScene("Main");
        }
    }

}
