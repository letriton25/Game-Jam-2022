using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3D : MonoBehaviour
{
    private Rigidbody m_rigid;
    private Vector3 m_Input;
    private int moveCoef = 1;
    private const float jumpForce = 6f;

    // Start is called before the first frame update
    void Start()
    {
        m_rigid = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //déplacement du personnage
        m_Input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Jump") * jumpForce, Input.GetAxis("Vertical"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        m_rigid.AddForce(m_Input * 30f * moveCoef, ForceMode.Force);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "floor")
            moveCoef = 1;
    }

    void OnCollisionExit(Collision col)
    {
        if(col.gameObject.tag == "floor")
            moveCoef = 0;
    }
}