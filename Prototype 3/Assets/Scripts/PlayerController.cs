using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody _playerRb;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playerRb.AddForce(Vector3.up*1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
