using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCondition : MonoBehaviour
{
    [SerializeField] private UIController uiController;
    [SerializeField] private string finishScene = "FinishScene";

    private void Update()
    {
        if (uiController.GetCurrentTimer() >= 0) return;

        SceneManager.LoadScene(finishScene);
    }
}
