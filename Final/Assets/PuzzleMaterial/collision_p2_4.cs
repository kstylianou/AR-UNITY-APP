// Collision detection for "piece 2" & "piece 4"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_p2_4 : MonoBehaviour
{
    public static bool snapped = false;
    public AudioSource audioData;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_4_2_Collision" && snapped == false)
        {
            snapped = true;
            audioData.Play();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "P_4_2_Collision" && snapped == true)
        {
            snapped = false;
        }
    }
}
