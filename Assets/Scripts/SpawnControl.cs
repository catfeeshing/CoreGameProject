using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    // Start is called before the first frame update

    private float startDelay = 5;
    private float spawnInterval = 10f;

    void Start()
    {
        InvokeRepeating("SpawnCustomer", startDelay, spawnInterval);
    }

    public GameObject[] customers;

    private float spawnRangeX = -1;
    private float spawnPosZ = 20;

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCustomer()
    {
        {
            int customerIndex = Random.Range(0, customers.Length-1);

            Instantiate(customers[customerIndex], new Vector3(spawnRangeX, 0, spawnPosZ), customers[customerIndex].transform.rotation);
        }
    }
}
