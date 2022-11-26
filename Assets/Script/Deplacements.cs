
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacements : MonoBehaviour
{
    //public bool activate;

    private Rigidbody m_rigid;
    
    public Camera mainCamera;

    public bool is_ortho = false;

    private bool is_collison = false;

    public Vector3 lastPos;

    private void Start()
    {
        m_rigid = gameObject.GetComponent<Rigidbody>();
    }


    public void KeyDeplacement()
    {
        //m_rigid.MovePosition(Vector3.right * 15f * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        //m_rigid.MovePosition(Vector3.up * 15f * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        
        //m_rigid.AddForce(Vector3.right * 15f * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        //m_rigid.AddForce(Vector3.up * 15f * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        
        
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        m_rigid.AddForce(m_Input * 100f, ForceMode.Force);

/*
        if (!is_collison)
        {
            transform.Translate(Vector3.right * 15f * Time.fixedDeltaTime * Input.GetAxis("Horizontal")); //Avance sur z
            transform.Translate(Vector3.up * 15f * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
            
            lastPos = transform.position;
        }*/
    }

    public void KeyZoom()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * 15f * Time.fixedDeltaTime); 

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 15f * Time.fixedDeltaTime); 

        }
    }

    public void orthographic_vision()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (is_ortho)
            {
                mainCamera.orthographic = false;
                is_ortho = false;
            }
            else
            {
                mainCamera.orthographic = true;
                is_ortho = true;
            }
            
        }
    }

    /*public void OnCollisionStay(Collision collision)
    {
        Vector3 diff = gameObject.transform.position - collision.gameObject.transform.position;
        
        transform.Translate(Vector3.right * -20f * Time.fixedDeltaTime * Input.GetAxis("Horizontal")); //Avance sur z
            
        transform.Translate(Vector3.up * -20f * Time.fixedDeltaTime * Input.GetAxis("Vertical")); //Avance sur x
    }*/
    

    public void OnCollisionEnter(Collision collision)
    {
        //is_collison = true;
        
        //Vector3 diff = gameObject.transform.position - collision.gameObject.transform.position;

        /* Vector3 diff = new Vector3();

        diff.x = gameObject.transform.position.x - collision.gameObject.transform.position.x;
        diff.y = 0f;
        diff.z = gameObject.transform.position.z - collision.gameObject.transform.position.z;
        
        transform.Translate(diff);*/

        //transform.position = lastPos;
    }
    public void OnCollisionExit(Collision collision)
    {
        //is_collison = false;
    }
    
    

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //KeyRotation();
        
        //if (gameObject.)
        KeyDeplacement();
        KeyZoom();
        orthographic_vision();
    }
}
