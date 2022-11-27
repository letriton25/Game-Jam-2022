using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public GameObject spawn;

    void OnCollisionEnter(Collision col)
    {
        col.gameObject.transform.position = spawn.transform.position;
    }
}
