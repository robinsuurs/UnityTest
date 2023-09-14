using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;

    private readonly Vector3 _spawnPos = new Vector3(25, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 2,2);
    }

    void SpawnObstacle()
    {
        Instantiate(prefab, _spawnPos, prefab.transform.rotation);
    }
    
}
