using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PUZZLE : MonoBehaviour
{
   

    void Update()
    {
        if(collision_p1_2.instance.IsSnapped() == true)
            Debug.Log("Trigger");

        //if (p1_Y == p2_Y)
        //{
        //    SceneManager.LoadScene("Main");
        //}
    }

}
