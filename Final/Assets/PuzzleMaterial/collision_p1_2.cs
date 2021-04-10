// Collision detection for "piece 1" & "piece 2"

using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision_p1_2 : MonoBehaviour
{
    public static bool snapped = false;
    public AudioSource audioData;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_1_2_Collision" && snapped == false)
        {
            snapped = true;
            audioData.Play();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "P_1_2_Collision" && snapped == true)
        {
            snapped = false;
        }
    }
}
