using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject enemyShip;
    public float enemySpeed = 2.0f;
    public int enemyHealth = 10;

    void Update()
    {
        // Move the ship down the y-axis at a constant speed
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        // If the ship falls off the screen, destroy it
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        // Reduce the ship's health by the damage amount
        enemyHealth -= damage;

        // If the ship's health drops to 0 or below, destroy it
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "laser")
        {
            print("hit");
        }

        if (other.gameObject.tag == "enemy")
        {
            print("hit");
        }
    }
}