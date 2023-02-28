using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;

    private float timeSinceLastSpawn = 0f;

    private void Start()
    {
        
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            timeSinceLastSpawn = 0f;

            // Randomize the spawn position
            float x = Random.Range(-12.35f, 13f);
            float y = 11.46f;
            float z = 0.0f;
            Vector3 spawnPosition = new Vector3(x, y, z);

            // Instantiate a new enemy ship and set its position
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            // Set the new enemy's health and speed
            EnemyController enemyShip = newEnemy.GetComponent<EnemyController>();
            enemyShip.enemyHealth = 10;
            enemyShip.enemySpeed = 2f;
        }
    }
}