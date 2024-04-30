using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollider : MonoBehaviour
{
    private List<Rigidbody> touchingPlayers = new List<Rigidbody>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a GameObject tagged as "Player" and add its Rigidbody to the list
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null && !touchingPlayers.Contains(playerRigidbody))
            {
                touchingPlayers.Add(playerRigidbody);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Check if the collision is with a GameObject tagged as "Player" and remove its Rigidbody from the list
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null && touchingPlayers.Contains(playerRigidbody))
            {
                touchingPlayers.Remove(playerRigidbody);
            }
        }
    }

    void FixedUpdate()
    {
        // Loop through all player Rigidbody objects touching the platform and add the platform's velocity to their velocities
        foreach (Rigidbody playerRigidbody in touchingPlayers)
        {
            playerRigidbody.velocity += GetComponent<Rigidbody>().velocity;
        }
    }
}
