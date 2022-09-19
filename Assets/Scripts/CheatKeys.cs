using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            int Sceneindex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(Sceneindex);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            int Sceneindex = SceneManager.GetActiveScene().buildIndex;

            if (Sceneindex <= SceneManager.sceneCount)
            {
                SceneManager.LoadScene(Sceneindex + 1);
            }

            else
            {
                SceneManager.LoadScene(0);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
