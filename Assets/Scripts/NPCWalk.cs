using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalk : MonoBehaviour
{
    public float speed;
    Rigidbody rbody;
    private Transform playerTransform;
    public Animator anim;

    void Start()
    {
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
