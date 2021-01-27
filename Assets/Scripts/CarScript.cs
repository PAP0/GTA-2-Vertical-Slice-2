using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    public float turn;
    Rigidbody rbody;

    private Transform playerTransform;
    public GameObject TheCar;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        playerTransform = GameObject.Find("Car").transform;
        TheCar = GameObject.FindWithTag("Car");
    }

    void Update()
    {
        Turn();
        Drive();
        Switch();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerPos = playerTransform.eulerAngles;
    }

    void Drive()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //transform.position += transform.forward * Time.deltaTime * speed;
            rbody.velocity = playerTransform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {

            //transform.position += transform.forward * Time.deltaTime * -speed;
            rbody.velocity = playerTransform.forward * -speed * Time.deltaTime;
        }
    }

    void Turn()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, -turn, 0 * turnspeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, turn, 0 * turnspeed * Time.deltaTime);
            }
        }
    }

    void Switch()
    {
        if (Input.GetKey(KeyCode.F))
        {
            TheCar.GetComponent<CarScript>().enabled = false;
        }
    }
}

