using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    public GameObject keyPrefab;
    public Transform[] spawnPoints;

   void Start()
    {
        // Randomly select a spawn point
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        // Set the desired rotation
        Quaternion spawnRotation = Quaternion.Euler(0f, 45f, 45f); // Rotation of (0, 45, 45)

        // Calculate the position slightly above the spawn point
        Vector3 spawnPosition = spawnPoint.position + Vector3.up * 0.5f; // Adjust the 0.5f value as needed

        // Instantiate the key at the selected spawn point with the desired rotation
        GameObject spawnedKey = Instantiate(keyPrefab, spawnPosition, spawnRotation);
    }
}
