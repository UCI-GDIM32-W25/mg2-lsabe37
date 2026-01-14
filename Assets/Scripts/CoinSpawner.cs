using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    private bool spawning;
    private float timer;
    private float spawnCoolDown;


    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnCoolDown)
        {
            SpawnCoin();
        }

    }

    private void SpawnCoin()
    {
        Instantiate(coin, transform.position, Quaternion.identity);
        spawnCoolDown = Random.Range(0.3f, 1.5f);
        timer = 0f;
    }
}
