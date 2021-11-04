using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownAnimalManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] animalPrefabs;

    private float spownRangeX = 20.0f;
    private float spownRangeZ = 20.0f;

    private float startDelay =2f;
    private float spownRate =1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spownRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spownPos = new Vector3(Random.Range(-spownRangeX, spownRangeX), 0, spownRangeZ);

        Instantiate(animalPrefabs[animalIndex], spownPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
