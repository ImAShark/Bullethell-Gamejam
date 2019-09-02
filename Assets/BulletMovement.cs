using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float speed = 10;

    // Update is called once per frame
    void Update()
    {
        
            print("!");
            transform.Translate(Vector2.up * speed*Time.deltaTime,Space.Self);

        
    }
}
