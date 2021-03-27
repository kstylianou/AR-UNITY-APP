using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_p3_4 : MonoBehaviour
{
    public static bool snapped = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_4_3_Collision")
        {
            snapped = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "P_4_3_Collision")
        {
            snapped = false;
        }
    }
}
