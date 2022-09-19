using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("finish"))
        {
            int previousSceneindex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = previousSceneindex + 1;

            if (nextSceneIndex == 4)
            {
                
                nextSceneIndex = 0;
            }

            else
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }
}
