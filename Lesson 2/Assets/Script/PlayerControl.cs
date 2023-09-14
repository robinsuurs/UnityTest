using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private float speed = 10;

    private Vector2 _movement;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.Translate(new Vector3(_movement.x ,0,_movement.y) * (speed * Time.deltaTime));
    }

    void OnMove(InputValue inputValue)
    {
        _movement = inputValue.Get<Vector2>();
    }

    void OnJump(InputValue inputValue)
    {
        _rigidbody.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
    }
}
