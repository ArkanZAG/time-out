using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [FormerlySerializedAs("playerRigidBody")] [SerializeField] private Transform playerTransform;
    [SerializeField] private float maxBorderValue;
    [SerializeField] private float minBorderValue;
    [SerializeField] private float moveRange;

    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < maxBorderValue)
        {
            playerTransform.position = new Vector2(playerTransform.position.x + moveRange, playerTransform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.A) && transform.position.x > minBorderValue)
        {
            playerTransform.position = new Vector2(playerTransform.position.x - moveRange, playerTransform.position.y);
        }
    }

    private void Update()
    {
        Movement();
    }
}
