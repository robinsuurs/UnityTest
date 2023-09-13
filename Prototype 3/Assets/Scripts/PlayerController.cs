using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody _playerRb;

    [SerializeField] private float jumpForce;
    [SerializeField] private float gravityModifier;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
