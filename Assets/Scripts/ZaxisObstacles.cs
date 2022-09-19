using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaxisObstacles : MonoBehaviour
{
    
    Vector3 startingPoint,
            offset;


    [SerializeField] float cyclePeriod = 2f;
    [SerializeField] Vector3 movementVector;
    [SerializeField][Range(0, 1)] float movementfactor;

    void Start()
    {
        startingPoint = transform.position;
    }

    void Update()
    {
        const float tau = Mathf.PI * 2;
        float cycles = Time.time / cyclePeriod;
        float rawSinValue = Mathf.Sin(cycles * tau);


        movementfactor = (rawSinValue + 1f) / 2;  //to make the values between 0 and 1

        offset = (movementfactor * movementVector);

        transform.position =  offset + startingPoint;
    }
}
