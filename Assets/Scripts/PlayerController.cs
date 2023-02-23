using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject laserPrefab;   // The prefab of the laser to shoot
    public float fireRate = 0.5f;    // The rate at which the player can shoot (in seconds)
    private float nextFire = 0.0f;   // The time of the next allowed shot

    // This component will handle player action and state
    public int health = 100;
    public float speed = 5.0f;

    //Player Limits variables
    public float verticalLimit = 3.3f;
    public float horizontalLimit = 8.3f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.up);

        if (transform.position.y > verticalLimit)
        {
            transform.position = new Vector3(transform.position.x, verticalLimit, 0f);
        }
        else if (transform.position.y < -verticalLimit)
        {
            transform.position = new Vector3(transform.position.x, -verticalLimit, 0f);
        }

        if (transform.position.x > horizontalLimit)
        {
            transform.position = new Vector3(horizontalLimit, transform.position.y, 0f);
        }
        else if (transform.position.x < -horizontalLimit)
        {
            transform.position = new Vector3(-horizontalLimit, transform.position.y, 0f);
        }

        if (Input.GetButton("Fire1") && Time.time > nextFire)   // Check if the player presses the fire button and if it's time for the next shot
        {
            nextFire = Time.time + fireRate;  // Set the time of the next allowed shot
            GameObject laserClone = Instantiate(laserPrefab, transform.position, Quaternion.identity);  // Create a new laser prefab at the player's position
            StartCoroutine(DestroyLaserClone(laserClone, 1.0f));  // Start coroutine to destroy laser clone after 2 seconds
        }
    }
    IEnumerator DestroyLaserClone(GameObject clone, float time = 0.1f)
    {
        yield return new WaitForSeconds(time);

        if (clone != null && !IsOnScreen(clone.transform.position))   // Check if the clone still exists and if it's off-screen
        {
            Destroy(clone);   // Destroy the clone
        }
    }

    bool IsOnScreen(Vector3 position)
    {
        Vector3 screenPoint = Camera.main.WorldToViewportPoint(position);
        return screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1 && screenPoint.z > 0;
    }
}