using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health = 1;

  

    private void Die()
    {
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
