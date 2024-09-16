using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;

    public float minSpawnTime = 0.5f; //min time between spawning blocks
    public float maxSpawnTime = 3.0f; //max time between spawning blocks

    void Start()
    {
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime); //this returns a random float between the two values
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;
        if (timeSinceLastSpawn > timeToNextSpawn)
        {
            int selection = Random.Range(0, objectsToSpawn.Length);
            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);//spawns a game object from our list
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);//after being spawned we select a new random time for the next spawn
            timeSinceLastSpawn = 0.0f;
        }
    }
}
