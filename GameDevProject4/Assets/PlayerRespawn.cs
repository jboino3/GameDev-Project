using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    // Tag to identify death objects
    public string deathObjectTag = "Respawn";

    // Spawn object for respawning
    public Transform respawnPoint;

    // Update is called once per frame
    void Update()
    {
        // Check if the player collides with any death objects
        foreach (Collider col in Physics.OverlapSphere(transform.position, 1.0f))
        {
            if (col.CompareTag(deathObjectTag))
            {
                // Respawn the player at the respawn point
                Respawn();
                break; // Exit loop once respawned
            }
        }
    }

    // Method to respawn the player
    void Respawn()
    {
        // Set the player's position to the respawn point
        transform.position = respawnPoint.position + Vector3.up * 0.5f;
        // Reset the player's velocity
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void SetRespawn(Transform newSpawn){
        respawnPoint = newSpawn;
    }
}
