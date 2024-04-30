using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springboard : MonoBehaviour
{
    // Variable property for the amount of force to apply
    public float power = 10f; // Placeholder value, you can experiment with this

    // Rigidbody component of the player ball
    public Rigidbody playerRigidbody;

    // Additional properties
    public bool block = true; // Whether to enable the wall collider
    public Transform wall; // Transform of the wall object
    private Collider wallCollider; // Collider component of the wall

    void Start()
    {
        // Get the Collider component of the wall
        if (wall != null)
        {
            wallCollider = wall.GetComponent<Collider>();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Check if the playerRigidbody is assigned
            if (playerRigidbody != null)
            {
                // Apply the upward force to launch the player
                playerRigidbody.AddForce(Vector3.up * power, ForceMode.Impulse);

                // Check if block is true and wallCollider is assigned
                if (block && wallCollider != null)
                {
                    // Enable the wall collider
                    wallCollider.enabled = true;

                    // Invoke method to disable the collider after 2 seconds
                    Invoke("DisableWallCollider", 2f);
                }
            }
        }
    }

    // Method to disable the wall collider
    void DisableWallCollider()
    {
        // Check if wallCollider is assigned
        if (wallCollider != null)
        {
            // Disable the wall collider
            wallCollider.enabled = false;
        }
    }
}