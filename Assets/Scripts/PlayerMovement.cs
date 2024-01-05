using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidBody;
    [SerializeField] private float playerMovementSpeed;

    private void Movement()
    {
        playerRigidBody.transform.localPosition = new Vector2(
            playerRigidBody.transform.localPosition.x * playerMovementSpeed, playerRigidBody.transform.localPosition.y);
    }

    private void Update()
    {
        playerRigidBody.transform.localPosition = new Vector2(
            playerRigidBody.transform.localPosition.x * playerMovementSpeed, playerRigidBody.transform.localPosition.y);
    }
}
