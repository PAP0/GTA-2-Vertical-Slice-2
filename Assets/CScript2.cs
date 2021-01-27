using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CScript2 : MonoBehaviour
{
    public GameObject thiscamera;
    void Update()
    {
        thiscamera.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
    }
}
