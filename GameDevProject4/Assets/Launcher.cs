using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Temporary move speed and jump force values
    public float tempMoveSpeed = 15f; // Temporary move speed
    public float tempJumpForce = 14f; // Temporary jump force

    // Original move speed and jump force values
    private float originalMoveSpeed;
    private float originalJumpForce;

    // Reference to the PlayerMovement script
    public PlayerMovement playerMovement; 

    void Start()
    {
        // Get the original move speed and jump force values from the PlayerMovement script
        if (playerMovement != null)
        {
            originalMoveSpeed = playerMovement.moveSpeed;
            originalJumpForce = playerMovement.jumpForce;
        }
    }

    // Method to launch the player
    public void LaunchPlayer()
    {
        // Check if the PlayerMovement script is assigned
        if (playerMovement != null)
        {
            // Temporarily change the move speed and jump force
            playerMovement.moveSpeed = tempMoveSpeed;
            playerMovement.jumpForce = tempJumpForce;

            // Reset the values after a delay
            Invoke("ResetPlayerMovement", 2f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the trigger collision involves the player ball
        if (other.CompareTag("Player"))
        {

            // Launch the player using the LaunchPlayer method
            LaunchPlayer();
        }
    }

    // Method to reset the player movement values
    void ResetPlayerMovement()
    {
        // Reset the move speed and jump force to their original values
        if (playerMovement != null)
        {
            playerMovement.moveSpeed = originalMoveSpeed;
            playerMovement.jumpForce = originalJumpForce;
        }
    }
}
