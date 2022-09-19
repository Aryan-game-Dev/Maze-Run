
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameload : MonoBehaviour
{
    public void LoadGame()
    {
      
        int previousSceneindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(previousSceneindex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");

    }
}