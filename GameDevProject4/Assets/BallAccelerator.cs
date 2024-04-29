using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAccelerator : MonoBehaviour
{
    public float accelerationFactor = 2f; // Factor by which to increase the player ball's velocity

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the player ball
        if (other.CompareTag("Player"))
        {
            // Get the Rigidbody component of the player ball
            Rigidbody playerBallRigidbody = other.GetComponent<Rigidbody>();
            
            // Increase the velocity of the player ball
            if (playerBallRigidbody != null)
            {
                playerBallRigidbody.velocity *= accelerationFactor;
            }
        }
    }
}
