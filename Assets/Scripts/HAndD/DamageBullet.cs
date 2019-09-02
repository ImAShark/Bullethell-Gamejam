using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{
    [SerializeField] private string objTag;

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("YEET");

        if (col.gameObject.tag == objTag)
        {
            col.gameObject.SendMessage("DealDamage", 1);
        }
    }
}
