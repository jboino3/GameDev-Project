using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float minOffsetTime = 2f; // Minimum offset time before laser starts
    public float maxOffsetTime = 4f; // Maximum offset time before laser starts
    public float onTime = 2f; // Time laser is on
    public float offTime = 2f; // Time laser is off

    private bool isLaserOn = false; // Flag to track laser state
    private MeshRenderer meshRenderer; // Reference to the MeshRenderer component

    void Start()
    {
        // Get the MeshRenderer component
        meshRenderer = GetComponent<MeshRenderer>();

        // Start the laser after a random offset time
        float offsetTime = Random.Range(minOffsetTime, maxOffsetTime);
        StartCoroutine(ActivateLaser(offsetTime));
    }

    IEnumerator ActivateLaser(float offsetTime)
    {
        // Wait for the random offset time
        yield return new WaitForSeconds(offsetTime);

        // Repeat indefinitely
        while (true)
        {
            // Turn on the laser
            SetLaserState(true);
            yield return new WaitForSeconds(onTime);

            // Turn off the laser
            SetLaserState(false);
            yield return new WaitForSeconds(offTime);
        }
    }

    void SetLaserState(bool state)
    {
        // Enable or disable the mesh renderer
        meshRenderer.enabled = state;

        // Set the tag based on the laser state
        if (state)
        {
            gameObject.tag = "Respawn";
        }
        else
        {
            gameObject.tag = "Untagged";
        }

        // Update the flag to track laser state
        isLaserOn = state;
    }
}
