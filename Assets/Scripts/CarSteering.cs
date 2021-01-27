using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSteering : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] 
    float accelerationPower = 5f;
    [SerializeField] 
    float steeringPower = 5f;
    float steeringAmount, speed, direction;

    void Start()
    { 
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        steeringAmount = - Input.GetAxis("Horizontal");
        speed = Input.GetAxis("Vertical");
    }
}
