using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Score : MonoBehaviour
{

    void Start()
    {
        var getInfo = GetComponent<Health>();
        getInfo.DiesE += CheckForType;
    }

    void Update()
    {
        
    }

    private void CheckForType(bool isMelee)
    {
        if (isMelee)
        {

        }
        else
        {

        }
    }
}
