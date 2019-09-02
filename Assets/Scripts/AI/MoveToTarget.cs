using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField]
    private string tag;
    [SerializeField]
    private float speed = 1;
    [SerializeField]
    private bool isMelee = false;
    private GameObject target;

    void Start()//sets tag
    {
        target = GameObject.FindGameObjectWithTag(tag);
    }

    void Update()
    {
        GoToTarget(target);
    }

    private void GoToTarget(GameObject targ)//makes it look towards the target and move towards there
    {
        RotateTowards(targ);
        float step = speed * Time.deltaTime;
        Vector3 pos = new Vector2(targ.transform.position.x, targ.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, pos, step);
    }

    private void RotateTowards(GameObject view)//calculates the rotation to look at
    {
        transform.right = view.transform.position - transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)//stops in target area
    {
        if (!isMelee)
        {
            speed = 0;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)//continues outside of target area
    {
        if (!isMelee)
        {
            speed = 1;
        }
    }
}
