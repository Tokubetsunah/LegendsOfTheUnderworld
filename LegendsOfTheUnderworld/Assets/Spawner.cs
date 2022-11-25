using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;
    public void SpawnUnit()
    {
        Instantiate(toSpawn, transform.position, Quaternion.identity);
    }


    float elapsedTime;
    float timeLimit = 3f;

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timeLimit)
        {
            elapsedTime = 0;
            SpawnUnit();
        }
    }
}
