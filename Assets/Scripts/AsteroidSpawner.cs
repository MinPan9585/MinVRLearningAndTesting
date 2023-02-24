using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public Vector3 spawnSize;
    public float spawnRate = 1f;
    [SerializeField] private GameObject asteroidModel;
    private float spawnTimer = 0f;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(transform.position, spawnSize);
    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnRate)
        {
            SpawnAsteroid();
            
            spawnTimer = 0f;
        }
    }

    private void SpawnAsteroid()
    {
        Vector3 spawnPoint = transform.position + new Vector3(
            UnityEngine.Random.Range(-spawnSize.x / 2, spawnSize.x / 2),
            UnityEngine.Random.Range(-spawnSize.y / 2, spawnSize.y / 2),
            UnityEngine.Random.Range(-spawnSize.z / 2, spawnSize.z / 2)
            );
        GameObject asteroid = Instantiate(asteroidModel, spawnPoint, Quaternion.identity);
        asteroid.transform.SetParent(this.transform);
    }
}
