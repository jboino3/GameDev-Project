using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    public Vector3 direction = Vector3.right;   // Direction of movement
    public float distance = 6f;                 // Total distance to move
    public float speed = 2f;                    // Movement speed
    public float pauseDuration = 1.5f; 

    private Vector3 initialPosition;            // Initial position of the platform
    private Vector3 targetPosition;             // Target position for movement
    private bool movingForward = true;          // Flag to track movement direction
    private float currentPause = 0f; 

    void Start()
    {
        // Store the initial position of the platform
        initialPosition = transform.position;
        // Calculate the target position for movement
        targetPosition = initialPosition + direction * distance;
    }

    void Update()
    {
        if (currentPause > 0f)
        {
            currentPause -= Time.deltaTime;
            if (currentPause <= 0f)
            {
                // Reset current pause duration
                currentPause = 0f;
            }
            else
            {
                return; // Skip movement while paused
            }
        }
        // Calculate movement step based on speed
        float step = speed * Time.deltaTime;

        // Move the platform towards the target position
        if (movingForward)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
            // Check if the platform has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
            {
                currentPause = pauseDuration;
                // Change movement direction
                movingForward = false;
            }
        }
        else
        {
            // Move the platform back to the initial position
            transform.position = Vector3.MoveTowards(transform.position, initialPosition, step);
            // Check if the platform has returned to the initial position
            if (Vector3.Distance(transform.position, initialPosition) < 0.001f)
            {
                currentPause = pauseDuration;
                // Change movement direction
                movingForward = true;
            }
        }
    }
}
