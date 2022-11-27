using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_to_square : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Square;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(Cam.transform.position.z - Square.transform.position.z) < 7f)
        {
            Square.gameObject.GetComponent<Animator>().enabled = false;
            Square.transform.position = new Vector3(0f, 0f, 30f);
            print("Close to square");
        }
    }
}
