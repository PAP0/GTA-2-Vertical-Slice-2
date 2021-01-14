using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMovement : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    Rigidbody rbody;

    private Transform playerTransform;
    private Vector3 relative;


    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        playerTransform = GameObject.Find("Player").transform;
    }

    void Update()
    {
        Rotate();
        Walk();
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 playerPos = playerTransform.eulerAngles;


    }

    void Walk()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rbody.velocity = playerTransform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rbody.velocity = playerTransform.forward * -speed * Time.deltaTime;
        }
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0 * turnspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0 * turnspeed * Time.deltaTime);
        }
    }
}
