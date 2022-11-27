using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_pointless : MonoBehaviour
{
    public float speed = 0.5f;

    private void Start()
    {
        transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.DownArrow)) && (transform.localScale.y > -0.6f))
        {
            transform.localScale += new Vector3(0f, -10f, 0f) * Time.deltaTime * speed;
        }
        if ((Input.GetKey(KeyCode.UpArrow)) && (transform.localScale.y < 0.6f))
        {
            transform.localScale += new Vector3(0f, 10f, 0f) * Time.deltaTime * speed;
        }
        if ((Input.GetKey(KeyCode.LeftArrow)) && (transform.localScale.x > -0.6f))
        {
            transform.localScale += new Vector3(-10f, 0f, 0f) * Time.deltaTime * speed;
        }
        if ((Input.GetKey(KeyCode.RightArrow)) && (transform.localScale.x < 0.6f))
        {
            transform.localScale += new Vector3(10f, 0f, 0f) * Time.deltaTime * speed;
        }
        if ((Input.GetKey(KeyCode.S)) && (transform.localScale.z > -0.6f))
        {
            transform.localScale += new Vector3(0f, 0f, -10f) * Time.deltaTime * speed;
        }
        if ((Input.GetKey(KeyCode.Z)) && (transform.localScale.z < 0.6f))
        {
            transform.localScale += new Vector3(0f, 0f, 10f) * Time.deltaTime * speed;
        }

        if ((float)Math.Abs(transform.localScale.x) * (float)Math.Abs(transform.localScale.y) *
            (float)Math.Abs(transform.localScale.z) > 0.216f)
        {
            print("valide");
        }
    }
}
