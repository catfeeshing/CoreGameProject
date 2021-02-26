using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 5.0f;
    private float horizontalInput;
    private float forwardInput;
    private float xRange = 7;
    private float zRange = 7;

    public GameObject foodProjectile;

    // Start is called before the first frame update
    void Start()
    {
        foodProjectile.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -90);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 90);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // launch a projectile from the player
            Instantiate(foodProjectile, transform.position, foodProjectile.transform.rotation);
        }

    }
}
