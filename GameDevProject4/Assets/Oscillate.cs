using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    public Vector3 direction = Vector3.right;   // Direction of movement
    public float distance = 5f;                 // Total distance to move
    public float speed = 2f;                    // Movement speed

    private Vector3 initialPosition;            // Initial position of the platform
    private Vector3 targetPosition;             // Target position for movement
    private bool movingForward = true;          // Flag to track movement direction

    void Start()
    {
        // Store the initial position of the platform
        initialPosition = transform.position;
        // Calculate the target position for movement
        targetPosition = initialPosition + direction * distance;
    }

    void Update()
    {
        // Calculate movement step based on speed
        float step = speed * Time.deltaTime;

        // Move the platform towards the target position
        if (movingForward)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
            // Check if the platform has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
            {
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
                // Change movement direction
                movingForward = true;
            }
        }
    }
}
