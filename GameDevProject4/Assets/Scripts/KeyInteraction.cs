using UnityEngine;

public class KeyInteraction : MonoBehaviour
{
    // Flag to track whether the key has been collected
    private bool isCollected = false;

    // Reference to the renderer component of the key
    private Renderer keyRenderer;

    void Start()
    {
        // Get the renderer component attached to the key
        keyRenderer = GetComponent<Renderer>();
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag("Player") && !isCollected)
        {
            // Mark the key as collected
            Debug.Log("collect");
            isCollected = true;

            // Deactivate the renderer to make the key disappear
            keyRenderer.enabled = false;

            // Inform the gate that the key has been collected
            GateController gateController = FindObjectOfType<GateController>();
            if (gateController != null)
            {
                gateController.KeyCollected();
            }
        }
    }

    // Method to check if the key has been collected
    public bool IsCollected()
    {
        return isCollected;
    }
}
