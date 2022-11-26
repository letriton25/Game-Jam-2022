using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public GameObject Square;

    bool transition = false;
    bool square_spawned = false;
    float spawnlocation = 6.5f;

    void start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0f, 0f, -10f) * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0f, 0f, 10f) * Time.deltaTime, Space.World);
        }
        /*if (this.transform.position.z < spawnlocation + 4f)
        {
            
        }

        if ((this.transform.position.z > 6f) && (square_spawned == false))
        {
            GameObject obj = Instantiate(Square);
            obj.transform.position = new Vector3(0f, 0.5f, spawnlocation);
            square_spawned = true;
        }

        if (square_spawned == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(new Vector3(-10f, 0f, 0f) * Time.deltaTime, Space.World);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(new Vector3(10f, 0f, 0f) * Time.deltaTime, Space.World);
            }
        }*/
        
        
        /*if (transition == false)
        {
            
        }
        else
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(new Vector3(0f, -10f, 0f) * Time.deltaTime, Space.World);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(new Vector3(0f, 10f, 0f) * Time.deltaTime, Space.World);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(new Vector3(-10f, 0f, 0f) * Time.deltaTime, Space.World);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(new Vector3(10f, 0f, 0f) * Time.deltaTime, Space.World);
            }
        }*/
        
        
    }
}
