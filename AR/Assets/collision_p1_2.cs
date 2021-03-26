using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision_p1_2 : MonoBehaviour
{
    bool snapped = false;
    GameObject snapparent; // the gameobject this transform will be snapped to
    Vector3 offset; // the offset of this object's position from the parent

    void Update()
    {
        if (snapped == true)
        {
            //retain this objects position in relation to the parent
            transform.position = this.transform.position + offset;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_2_Collision")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            //SceneManager.LoadScene("Main");

            snapped = true;
            snapparent = col.gameObject;
            offset = transform.position - snapparent.transform.position; //store relation to parent

        }
    }
}
