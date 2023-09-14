using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    private PlayerController _playerControllerScript;
    
    private readonly Vector3 _spawnPos = new Vector3(25, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 2,2);
        _playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (_playerControllerScript.gameOver == false)
        {
            Instantiate(prefab, _spawnPos, prefab.transform.rotation);
        }
    }
    
}
