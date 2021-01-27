using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    [SerializeField] private GameObject _NPC;
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] public float _spawnThreshold = 2;

    public float _timer;

    private void Start()
    {
        SpawnEnemy();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnThreshold)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);
        SpawnPoint spawnpoint = _spawnPoints[randomIndex];
        Vector3 spawnPosition = spawnpoint.GetSpawnPosition();

        Instantiate(_NPC, spawnPosition, spawnpoint.transform.rotation);
        _timer = 0;
    }
}
