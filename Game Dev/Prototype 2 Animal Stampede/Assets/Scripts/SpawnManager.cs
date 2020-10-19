using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawwnPosZ = 30f;
    
    private float startDelay = 2.0f;
    private float SpawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandAnimal", startDelay, spawnIntervenal)
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
        
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Inistiate(animalPrefabs{animalIndex},spawnPos, animalPrefabs{animalIndex}.transform.rotation)
    
    }
}
