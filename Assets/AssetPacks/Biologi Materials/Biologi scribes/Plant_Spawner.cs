using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSpawner : MonoBehaviour
{
    public GameObject SpawnVgalnebr;
    public GameObject SpawnSvamp;
    public GameObject SpawnVinterbr;
    public GameObject SpawnHvidFrugt;
    public GameObject SpawnBush;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomSpawnPosition = new(Random.Range(-10,11), 1, Random.Range(-10, 11));
        Instantiate(SpawnVgalnebr, randomSpawnPosition, Quaternion.identity);
        Vector3 randomSpawnPosition1 = new(Random.Range(-10, 11), 0, Random.Range(-10, 11));
        Instantiate(SpawnSvamp, randomSpawnPosition1, Quaternion.identity);
        Vector3 randomSpawnPosition2 = new(Random.Range(-10, 11), 1, Random.Range(-10, 11));
        Instantiate(SpawnVinterbr, randomSpawnPosition2, Quaternion.identity);
        Vector3 randomSpawnPosition3 = new(Random.Range(-10, 11), 1, Random.Range(-10, 11));
        Instantiate(SpawnHvidFrugt, randomSpawnPosition3, Quaternion.identity);
        Vector3 randomSpawnPosition4 = new(Random.Range(-10, 11), 0, Random.Range(-10, 11));
        Instantiate(SpawnBush, randomSpawnPosition4, Quaternion.identity);

    }

    
}
