using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject EnemyS, EnemyM;
    [SerializeField] private float timer, reset = 1;

    void Update()
    {
        if (timer <= 0)
        {
            SpawnEnemy();
            timer = reset;
        }
        timer = timer - Time.deltaTime;
        
    }

    private void SpawnEnemy()
    {
        float t = Mathf.Floor(Random.Range(0,2));
        if (t == 0)
        {
            Debug.Log("Shooter Spawned");
            Instantiate(EnemyS,transform.position,Quaternion.identity);
        }
        else if (t == 1)
        {
            Debug.Log("Melee Spawned");
            Instantiate(EnemyM, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("Big oof");
        }
    }
}
