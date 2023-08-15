using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController _playerController;
    
    public GameObject obstablePrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;
    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (_playerController.gameOver == false)
        {
            Instantiate(obstablePrefabs, spawnPos, obstablePrefabs.transform.rotation);
        }
    }
}
