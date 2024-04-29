using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    // Name of the scene to transition to
    public string sceneName = "Title";

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag("Player"))
        {
           Time.timeScale = 1.0f;
           // Load the specified scene
            SceneManager.LoadScene(sceneName);
        }
    }
}
