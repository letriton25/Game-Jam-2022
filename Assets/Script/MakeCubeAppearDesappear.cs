using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MakeCubeAppearDesappear : MonoBehaviour
{
    public GameObject Object;
    public GameObject Cam;
    bool activate;
    private bool altern;

    void Start()
    {
        
        activate = true;
        altern = false;
        StartCoroutine(ShowAndHide());
    }


    IEnumerator ShowAndHide()
    {

        //if you want a stop this circle then false active value..
        while(true)
        {
            print((float)Math.Abs(Cam.transform.position.z - Object.transform.position.z));
            if (Math.Abs(Cam.transform.position.z - Object.transform.position.z) < 7f)
            {
                Object.GetComponent<Renderer>().enabled = true;
                break;
            }
            Object.GetComponent<Renderer>().enabled = !Object.GetComponent<Renderer>().enabled;
            yield return new WaitForSeconds(Random.Range(0.5f,3f)); 
        }
    }
}
