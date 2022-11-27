using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeSegmentsDetect : MonoBehaviour
{
    public Canvas canvasSegments;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            canvasSegments.gameObject.SetActive(true);
    }
    
    private void OnTriggerExit(Collider other)
    {
        print("segments");
        canvasSegments.gameObject.SetActive(false);
    }
    
    
}
