using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPont : MonoBehaviour
{
    public GameObject controlKeysImage;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.transform.name == "player"){
            controlKeysImage.SetActive(true);
            col.gameObject.GetComponent<scalingPont>().scalingCoef = 1;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.transform.name == "player"){
            controlKeysImage.SetActive(false);
            col.gameObject.GetComponent<scalingPont>().scalingCoef = 0;
        }
    }
}
