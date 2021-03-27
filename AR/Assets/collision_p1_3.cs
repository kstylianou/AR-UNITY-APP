using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_p1_3 : MonoBehaviour
{
    public static bool snapped = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_1_3_Collision")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            //SceneManager.LoadScene("Main");

            snapped = true;
        }
        else
        {
            snapped = false;
        }
    }
}
