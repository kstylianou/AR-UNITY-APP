// Collision detection for "piece 2" & "piece 4"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_p2_4 : MonoBehaviour
{
    public static bool snapped = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_4_2_Collision")
        {
            snapped = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "P_4_2_Collision")
        {
            snapped = false;
        }
    }
}
