// Collision detection for "piece 1" & "piece 3"

using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision_p1_3 : MonoBehaviour
{
    public static bool snapped = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_1_2_Collision")
        {
            snapped = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "P_1_2_Collision")
        {
            snapped = false;
        }
    }
}
