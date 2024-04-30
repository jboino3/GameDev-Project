using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTiles : MonoBehaviour
{
    private Vector3 originalPosition; // Original position of the tile
    private bool isFalling = false;   // Flag to track if the tile is falling
    private Renderer tileRenderer;     // Reference to the renderer component
    private float fallDuration = 5f;   // Duration of falling before disabling renderer
    private float fallTimer = 0f;      // Timer for tracking falling duration

    public float fallSpeed = 10f;      // Speed at which the tile falls

    void Start()
    {
        // Store the original position of the tile
        originalPosition = transform.position;
        // Get the renderer component
        tileRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a player tagged object
        if (collision.gameObject.CompareTag("Player"))
        {
            // Start falling
            isFalling = true;
            // Reset the fall timer
            fallTimer = 0f;
        }
    }

    void Update()
    {
        // Move the tile down gradually if it is falling
        if (isFalling)
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
            // Increment the fall timer
            fallTimer += Time.deltaTime;
            // Check if the fall duration has been reached
            if (fallTimer >= fallDuration)
            {
                // Disable the renderer after the specified duration
                tileRenderer.enabled = false;
                // Reset the falling state
                isFalling = false;
            }
        }
    }

    public void Reset()
    {
        // Reset the tile to its original position
        transform.position = originalPosition;
        // Enable the renderer
        tileRenderer.enabled = true;
        isFalling = false; 
    }
}