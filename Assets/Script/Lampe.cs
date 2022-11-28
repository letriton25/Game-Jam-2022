using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Lampe : MonoBehaviour
{
    public Camera mainCamera;

    public bool moveCam;

    public float stopMouv;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            moveCam = true;
            
            stopMouv = mainCamera.orthographicSize + 1f;
        }
    }

    void Update()
    {
        if (moveCam)
        {
            if (mainCamera.orthographicSize < stopMouv)
            {
                mainCamera.orthographicSize += Time.deltaTime;
            }
            else
            {
                moveCam = false;
            }
        }
    }
}
