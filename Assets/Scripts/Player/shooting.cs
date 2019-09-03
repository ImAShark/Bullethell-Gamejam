using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    AudioSource AS;
    float shottimer = 0;
    private Vector3 target;
    private Camera camera;
    private Transform shotpoint;
    [SerializeField] private GameObject bullet;
    private void Start()
    {
        AS = GetComponent<AudioSource>();
        camera = Camera.main;
        shotpoint = transform.GetChild(0);
    }

    void Update()
    {
        Rotate();
        Shoot();
        shottimer += 1 * Time.deltaTime;
    }

    private void Rotate()
    {

        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

    }

    void Shoot()
    {
        if (Canfire(0.7f))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                AS.Play();
                Instantiate(bullet, shotpoint.position, shotpoint.rotation);
            }
        }
    }


        bool Canfire(float timer)
        {
            if (shottimer >= timer)
            {
                shottimer = 0;
                return true;

            }
            else
            {
                return false;
            }
        }
}

