using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Walls : MonoBehaviour
{
    public Vector3 targetPosition; // Target position to move the wall
    public GameObject wallToMove; // Wall to move
    public float moveSpeed = 5f; // Speed at which the wall moves


    private bool isMoving = false; // Flag to track if the wall is currently moving
    private bool isTriggered = false;

    private void Update()
    {
        if (isMoving)
        {
            MoveWall();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isTriggered) {
        if (other.CompareTag("Player"))
        {
            isMoving = true;
            isTriggered = true;
            targetPosition += wallToMove.transform.position;
        }
        }
    }

    private void MoveWall()
    {
        // Calculate the distance between the current position and the target position
        float distance = Vector3.Distance(wallToMove.transform.position, targetPosition);

        // If the distance is less than 0.1, stop moving the wall
        if (distance < 0.1f)
        {
            isMoving = false;
            return;
        }

        // Calculate the direction in which the wall should move
        Vector3 direction = (targetPosition - wallToMove.transform.position).normalized;

        // Calculate the distance to move this frame
        float distanceToMove = moveSpeed * Time.deltaTime;

        // If the distance to move is greater than the remaining distance, set the distance to move to the remaining distance
        if (distanceToMove > distance)
        {
            distanceToMove = distance;
        }

        // Calculate the new position of the wall
        Vector3 newPosition = wallToMove.transform.position + direction * distanceToMove;

        // Update the position of the wall
        wallToMove.transform.position = newPosition;
    }
}
