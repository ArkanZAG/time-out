using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

public class Movement : MonoBehaviour
{
    [FormerlySerializedAs("enemyTransform")] [SerializeField] private Transform moveTransform;
    [SerializeField] private float startSpeed;
    [SerializeField] private float endSpeed;
    private Timer timer;
    
    private bool isMovingToPointB = true;

    private void Update()
    {
        MoveTowardsPointB();
    }

    //Function to Inject
    public void Initialize(Timer newTimer)
    {
        timer = newTimer;
    }

    private void MoveTowardsPointB()
    {
        //Determine lerp speed base on limer progress
        float speed = Mathf.Lerp(startSpeed, endSpeed, timer.GetNormalizedProgress());
        moveTransform.position = new Vector2(moveTransform.position.x, moveTransform.position.y - Time.deltaTime * speed);
    }
}
