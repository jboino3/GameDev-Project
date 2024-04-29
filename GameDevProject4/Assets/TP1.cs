using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP1 : MonoBehaviour
{
    public Transform teleport;
    public bool respawn;  
    public PlayerRespawn playerRespawn; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is a player object
        if (other.CompareTag("Player"))
        {
            // Teleport the player to the teleport target position
            other.transform.parent.position = teleport.position + Vector3.up * 0.5f;
            other.transform.parent.GetComponent<Rigidbody>().velocity = Vector3.zero;

            if (respawn){
                playerRespawn.SetRespawn(teleport);
            }
        }
    }
}
