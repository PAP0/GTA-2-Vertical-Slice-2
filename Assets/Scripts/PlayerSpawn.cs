using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject PlayerPrefav;
    public GameObject ThePlayer;

    void Start()
    {
        ThePlayer = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        gettfout();
    }

    void gettfout()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject Player = Instantiate(PlayerPrefav, SpawnPoint.position, SpawnPoint.rotation);
            Rigidbody rbody = Player.GetComponent<Rigidbody>();
        }

        if (Input.GetKey(KeyCode.G))
        {
            ThePlayer.GetComponent<PMovement>().enabled = true;
        }
    }
}
