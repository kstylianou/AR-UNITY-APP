using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PUZZLE : MonoBehaviour
{

    public GameObject puzzle_1_2;

    void Update()
    {
        if(puzzle_1_2.GetComponent<collision_p1_2>().IsSnapped() == true)
            SceneManager.LoadScene("Main");
            //Debug.Log("Trigger");

        //if (p1_Y == p2_Y)
        //{
        //    SceneManager.LoadScene("Main");
        //}
    }

}
