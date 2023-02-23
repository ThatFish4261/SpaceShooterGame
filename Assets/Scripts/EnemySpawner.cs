using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public Vector3 spawnPosition;
    public float spawnRadius = 5f;


    private float timeSinceLastSpawn = 0f;

    private void Start()
    {

    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            // Reset the spawn timer
            timeSinceLastSpawn = 0f;

            // Instantiate a new enemy ship and set its position
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            // Set the new enemy's health and speed
            EnemyController enemyShip = newEnemy.GetComponent<EnemyController>();
            enemyShip.enemyHealth = 10;
            enemyShip.enemySpeed = 2f;
        }
    }
}