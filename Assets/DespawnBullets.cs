using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnBullets : MonoBehaviour
{
    Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        if (!rend.isVisible)
        {
            Destroy(gameObject);
        }
                
    }
}
