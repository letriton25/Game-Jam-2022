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
    }
}
