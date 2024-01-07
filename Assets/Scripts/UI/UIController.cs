using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float currentTimer;
    [SerializeField] private Button restartButton;
    [SerializeField] private string gameScene = "GameScene";
    
    
    private float maxTimer;

    private void Awake()
    {
        maxTimer = currentTimer;
        restartButton.onClick.AddListener(RestartGame);
    }

    private void Update()
    {
        currentTimer -= Time.deltaTime;
        timerText.text = currentTimer.ToString();
    }

    public float GetNormalizedProgress()
    {
        var a = 1 - (currentTimer / maxTimer);
        return a;
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(gameScene);
    }

    public float GetCurrentTimer()
    {
        return currentTimer;
    }
}
