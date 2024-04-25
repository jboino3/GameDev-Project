using UnityEngine;

public class GateController : MonoBehaviour
{
    // Reference to the gate GameObject
    public GameObject gate;
    public MeshCollider gateCollider; 
    public CapsuleCollider capsuleCollider;


    // Flag to track whether the key has been collected
    private bool keyCollected = false;

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player and the key has been collected
        if (other.CompareTag("Player") && keyCollected)
        {
            // Deactivate the gate
            gate.SetActive(false);
            gateCollider.enabled = false; 
        }
    }

    // Method to handle when the key is collected
    public void KeyCollected()
    {
        keyCollected = true;
        capsuleCollider.enabled = true;
    }
}
