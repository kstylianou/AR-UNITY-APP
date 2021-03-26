using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision_p1_2 : MonoBehaviour
{
  void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene("Main");

        if (col.GetComponent<Collider>().name == "puzzle_p2_1")
        {
            SceneManager.LoadScene("Main");
        }
    }
}
