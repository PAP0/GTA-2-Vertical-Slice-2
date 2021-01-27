using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public Animator anim;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Shoot();
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            anim.SetBool("isWalking", false);
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody rbody = bullet.GetComponent<Rigidbody>();
        rbody.AddForce(firepoint.forward * bulletForce, ForceMode.Impulse);
    }
}
