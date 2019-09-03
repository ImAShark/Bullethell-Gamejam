using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health = 1;
    [SerializeField]
    private bool isPlayer = false, isMelee = false;
    private bool isAlive = true;

    public event Action DiesP;
    public event Action<bool> DiesE;

    void Update()
    {
        if (!isAlive && Time.timeScale > 0.01f)
        {
            Time.timeScale = Time.timeScale - 0.01f;
        }
        
    }   

    public void DealDamage(int damage)
    {
        health = health - damage;

        if (health <= 0)
        {
            Die();
        }
        
    }

    private void Die()
    {
        if (isPlayer)
        {
            DiesP();
            isAlive = false;
        }
        else
        {
            DiesE(isMelee);
        }

        Destroy(gameObject);
    }
}
