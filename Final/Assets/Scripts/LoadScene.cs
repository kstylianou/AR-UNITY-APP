//Manages the scene that will be previewed

using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public Button UpdateScene;
    
    public string sceneName;
    public static string previus;

    public void LoadNewScene(string sceneName)
    {
        
        SceneManager.LoadScene(sceneName);
        
    }

    void Start()
    {
        Button btn = UpdateScene.GetComponent<Button>();
        //onclick listener
        btn.onClick.AddListener(() => LoadNewScene(sceneName));
    }

    // If scene = game then the previous screen is the current game playing 
    // The purpose is to navigate the user to play again the current game 
    public void GamePlaying(string name)
    {
        previus = name;
    }
}
