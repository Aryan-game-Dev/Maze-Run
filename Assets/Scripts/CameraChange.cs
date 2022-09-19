using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Map") == true)
        {
            GetComponent<Camera>().enabled = true;
        }
        else
        {
            GetComponent<Camera>().enabled = false;
        }
    }

    
}
