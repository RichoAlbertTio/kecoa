using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject kecoa;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", 0.4f, 0.4f);
    }

    void spawner()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-2.49f, 2.50f), -6.11f);
        Instantiate(kecoa, spawnPos, Quaternion.identity);
    }
}
