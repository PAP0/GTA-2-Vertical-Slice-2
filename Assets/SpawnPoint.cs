using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3 GetSpawnPosition()
    {
        return transform.GetChild(0).position;
    }
}
