using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private float value,scoreTotal;

    void Update()
    {
        scoreTotal += Mathf.Ceil (value * Time.deltaTime);
        score.text = "score: " + scoreTotal;
    }

}
