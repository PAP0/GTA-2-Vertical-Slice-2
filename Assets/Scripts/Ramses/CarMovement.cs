using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour, IMoveable
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private KeyCode _controlKey;
    
    public float turnspeed;

    private Rigidbody _rigidBody;

    protected void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    protected void Update()
    {
        if(Input.GetKeyDown(_controlKey))
        {
            FindObjectOfType<PlayerController>().GainControl(this);
        }
    }

    public void RotateLeft()
    {
        transform.Rotate(0, -1, 0 * turnspeed * Time.deltaTime);
    }

    public void RotateRight()
    {
        transform.Rotate(0, 1, 0 * turnspeed * Time.deltaTime);
    }

    public void MoveForward()
    {
        _rigidBody.velocity = transform.forward * _speed * Time.deltaTime;  
    }

    public void MoveBackwards()
    {
        _rigidBody.velocity = transform.forward * -_speed * Time.deltaTime;
    }
}
