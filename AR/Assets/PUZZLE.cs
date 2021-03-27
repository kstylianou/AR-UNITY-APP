using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PUZZLE : MonoBehaviour
{

    void Update()
    {
        //Debug.Log("P1 " + collision_p1_2.snapped);
        //Debug.Log("P3 " + collision_p1_3.snapped);

        if (collision_p1_2.snapped == true && collision_p1_3.snapped == true && collision_p2_4.snapped == true && collision_p3_4.snapped == true)
            SceneManager.LoadScene("Main");
            //Debug.Log("Trigger");

        //if (p1_Y == p2_Y)
        //{
        //    SceneManager.LoadScene("Main");
        //}
    }

}
