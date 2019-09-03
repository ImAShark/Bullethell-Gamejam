using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health = 1;
    [SerializeField]
    private bool isPlayer = false;
    private bool isAlive = true;

    public event Action DiesP;

    void Update()
    {
        if (!isAlive && Time.timeScale > 0.01f)
        {
            Time.timeScale = Time.timeScale - 0.01f;
        }
        
    }

    private void Die()
    {
        if (isPlayer)
        {
            DiesP();
            isAlive = false;
        }
        
        Destroy(gameObject);
    }

    public void DealDamage(int damage)
    {
        health = health - damage;

        if (health <= 0)
        {
            Die();
        }
        
    }
}
