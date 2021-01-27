using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHealth : MonoBehaviour
{
    [SerializeField] private int health;
    public float speed;
    public Animator anim;
    void Start()
    {
        speed = 2;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Bullet")
        {
            if (health <= 1)
            {
                anim.SetBool("isDead", true);
                speed = 0;
            }
            else
            {
                takeDamage();
            }
        }

        if (col.gameObject.tag == "Wall")
        {
            transform.RotateAround(transform.position, transform.up, 180f);
        }
    }

    void OnCollisionEnter(Collision col)
    {
    }

    void takeDamage()
    {
        health -= 1;
    }

    void Update()
    {
        if (health <= 1)
        {
            anim.SetBool("isDead", true);
            speed = 0;
        }
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
