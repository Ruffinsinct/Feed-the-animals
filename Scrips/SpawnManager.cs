using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;

    private float spawnPosX = 15.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 1.5f;
    private float timeIntervals = 2.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, timeIntervals);
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0 , spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }
}
