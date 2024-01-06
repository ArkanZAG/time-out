using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float currentTimer;
    private float maxTimer;

    private void Awake()
    {
        maxTimer = currentTimer;
    }

    private void Update()
    {
        currentTimer -= Time.deltaTime;
        timerText.text = currentTimer.ToString("F1");
    }

    public float GetNormalizedProgress()
    {
        var a = 1 - (currentTimer / maxTimer);
        return a;
    }
}
