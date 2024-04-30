using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float minOffsetTime = 2f; 
    public float maxOffsetTime = 4f; 
    public float onTime = 2f; 
    public float offTime = 2f;

    private bool isLaserOn = false; 
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();

        float offsetTime = Random.Range(minOffsetTime, maxOffsetTime);
        StartCoroutine(ActivateLaser(offsetTime));
    }

    IEnumerator ActivateLaser(float offsetTime)
    {
        yield return new WaitForSeconds(offsetTime);

        while (true)
        {
           
            SetLaserState(true);
            yield return new WaitForSeconds(onTime);

           
            SetLaserState(false);
            yield return new WaitForSeconds(offTime);
        }
    }

    void SetLaserState(bool state)
    {
       
        meshRenderer.enabled = state;
        GetComponent<Collider>().enabled = state;

      
        if (state)
        {
            gameObject.tag = "Respawn";
        }
        else
        {
            gameObject.tag = "Untagged";
        }

        isLaserOn = state;
    }
}
