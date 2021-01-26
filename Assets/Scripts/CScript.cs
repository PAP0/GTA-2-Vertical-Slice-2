
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CScript : MonoBehaviour
{
    public Transform _playerPosition;

    [SerializeField] Vector3 offset = new Vector3(0, 21.791f, 0);

    private float startFOV = 60f;
    private float maxFOV = 60f;


    void FixedUpdate()
    {
        Vector3 desiredPosition = _playerPosition.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, 2.0f * Time.deltaTime);

        transform.position = smoothedPosition;

        if (Input.GetKey(KeyCode.W) == true || Input.GetKey(KeyCode.S) == true || Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.D) == true)
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, maxFOV, 1.0f * Time.deltaTime);
        }
        else
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, startFOV, 1.0f * Time.deltaTime);
        }
    }
}
