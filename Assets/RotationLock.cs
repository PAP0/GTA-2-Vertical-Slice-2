using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLock : MonoBehaviour
{
    public GameObject thiscamera;
    void Awake()
    {
        thiscamera.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
    }
}
