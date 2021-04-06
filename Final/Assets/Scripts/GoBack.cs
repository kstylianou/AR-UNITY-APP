//Script for navigating to the previous scene

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public string sceneName;

    public void GoBackNow()
    {
        SceneManager.LoadScene(sceneName);
    }
}
