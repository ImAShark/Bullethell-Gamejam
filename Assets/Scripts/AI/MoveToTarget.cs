using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField]
    private string tag;
    [SerializeField]
    private float speed = 1;
    private GameObject target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag(tag);
    }

    void Update()
    {
        GoToTarget(target);
    }

    private void GoToTarget(GameObject targ)
    {
        float step = speed * Time.deltaTime;
        Vector3 pos = new Vector2(targ.transform.position.x, targ.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, pos, step);
    }
}
