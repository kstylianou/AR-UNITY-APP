using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PUZZLE : MonoBehaviour
{

    public Text countText;

    void Update()
    {
        if (collision_p1_2.snapped == true && collision_p1_3.snapped == true && collision_p2_4.snapped == true && collision_p3_4.snapped == true)
            SceneManager.LoadScene("Main");

        countText.text = "Markers Found: " + DefaultTrackableEventHandler.countNum + "/4";
    }

}
