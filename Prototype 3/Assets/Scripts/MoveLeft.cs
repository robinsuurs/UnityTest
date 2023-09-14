using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed =30;
    [SerializeField] private float leftBound = -15;
    private PlayerController _playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        _playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * (speed * Time.deltaTime));
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
