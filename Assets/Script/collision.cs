using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class collision : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Square;
    /*private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "square")
        {
            Debug.Log("collision");
        }
    }*/
    void Update()
    {
        if ((Cam.transform.position.z-6f > Square.transform.position.z - Square.transform.localScale.z) && (Cam.transform.position.z-6f < Square.transform.position.z + Square.transform.localScale.z))
        {
            print("in");
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(new Vector3(-10f, 0f, 0f) * Time.deltaTime, Space.World);
            }
        }
    }
}
