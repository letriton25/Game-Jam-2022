using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTeleporte : MonoBehaviour
{
    public GameObject perso;

    public GameObject lab2D;

    public GameObject lab3D;

    public Camera camera;

    private void OnTriggerEnter(Collider other)
    {
        perso.transform.position = new Vector3(0, 110, 0);
        
        lab2D.SetActive(false);
        lab3D.SetActive(true);
        
        WaitToPlay();
        WaitToPlay2();
    }
    
    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        camera.orthographic = false;
    }

    void WaitToPlay()
    {
        StartCoroutine(Delay());
    }
    
    public IEnumerator Delay2()
    {
        yield return new WaitForSeconds(3f);
        perso.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        perso.GetComponent<Rigidbody>().drag = 1f;
        print("okk");
        
    }

    void WaitToPlay2()
    {
        StartCoroutine(Delay2());
    }
}
