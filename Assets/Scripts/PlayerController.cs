using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This component will handle player action and state
    public int health = 100;
    public float speed = 1.0f;

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

        if (transform.position.y > 3.3f)
        {
            transform.position = new Vector3(transform.position.x, 3.3f, 0f);
        }
        else if (transform.position.y < -3.9f)
        {
            transform.position = new Vector3(transform.position.x, -3.95f, 0f);
        }

        if (transform.position.x > 10.3f)
        {
            transform.position = new Vector3(10.3f, transform.position.y, 0f);
        }
        else if (transform.position.x < -3.9f)
        {
            transform.position = new Vector3(-10.3f, transform.position.y, 0f);
        }

    }
}