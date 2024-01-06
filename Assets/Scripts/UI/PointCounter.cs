using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;

    public void AddScore(int point)
    {
        score += point;
        scoreText.text = score.ToString();
    }

    public void ReduceScore(int point)
    {
        score -= point;
        scoreText.text = score.ToString();
    }
}
