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

    public event Action<string> Dies;

  

    private void Die()
    {
        if (isPlayer)
        {
            Dies("p");
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
