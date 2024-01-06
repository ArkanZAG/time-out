using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private Transform pointB;
    [SerializeField] private float speed = 1.0f;
    
    private bool isMovingToPointB = true;

    private void Update()
    {
        MoveTowardsPointB();
    }

    private void MoveTowardsPointB()
    {
        enemyTransform.position = Vector2.MoveTowards(enemyTransform.position, pointB.position, speed * Time.deltaTime);

        if (Vector2.Distance(enemyTransform.position, pointB.position) < 0.01f)
        {
            
        }
    }
}
