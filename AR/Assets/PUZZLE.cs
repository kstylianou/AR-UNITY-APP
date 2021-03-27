using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PUZZLE : MonoBehaviour
{

    void Update()
    {
        Debug.Log(collision_p1_2.snapped);

        if(collision_p1_2.snapped == true && collision_p1_3.snapped == true)
            SceneManager.LoadScene("Main");
            //Debug.Log("Trigger");

        //if (p1_Y == p2_Y)
        //{
        //    SceneManager.LoadScene("Main");
        //}
    }

}
