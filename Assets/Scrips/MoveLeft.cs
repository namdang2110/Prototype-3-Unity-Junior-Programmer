using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController _playerController;

    private float leftBound = -15;
    
    void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (_playerController.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
