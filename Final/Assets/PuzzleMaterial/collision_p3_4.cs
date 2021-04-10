// Collision Detection for "piece 3" & "piece 4"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_p3_4 : MonoBehaviour
{
    public static bool snapped = false;
    public AudioSource audioData;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_4_3_Collision" && snapped == false)
        {
            snapped = true;
            audioData.Play();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "P_4_3_Collision" && snapped == true)
        {
            snapped = false;
        }
    }
}
