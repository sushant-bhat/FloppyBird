using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject _obstaclePrefab;
    [SerializeField] float _timeBetweenSpawns = 2f;

    float _currentTime;
    Queue<GameObject> _obstaclePool;

    private void Awake()
    {
        FloppyBirdEvents.obstacleDestroyEvent.AddListener(OnObstacleDestroy);
        _obstaclePool = new Queue<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime >= _timeBetweenSpawns)
        {
            Vector3 spawnPosition = GetSpawnPosition();
            if (_obstaclePool.Count != 0)
            {
                GameObject obstacle = _obstaclePool.Dequeue();
                obstacle.transform.position = spawnPosition;
                obstacle.SetActive(true);
            }
            else
            {
                GameObject obstacle = Instantiate(_obstaclePrefab, spawnPosition, Quaternion.identity);
            }
            _currentTime = 0f;
        }
    }

    private Vector3 GetSpawnPosition()
    {
        float yPosition = Random.Range(-3.0f, 3.0f);
        return new Vector3(transform.position.x, yPosition, transform.position.z);
    }

    private void OnObstacleDestroy(GameObject obstacle)
    {
        obstacle.SetActive(false);
        _obstaclePool.Enqueue(obstacle);
    }
}
