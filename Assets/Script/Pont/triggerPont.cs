using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPont : MonoBehaviour
{
    public GameObject controlKeysCanvas;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.transform.name == "player"){
            controlKeysCanvas.SetActive(true);
            col.gameObject.GetComponent<scalingPont>().scalingCoef = 1;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.transform.name == "player"){
            controlKeysCanvas.SetActive(false);
            col.gameObject.GetComponent<scalingPont>().scalingCoef = 0;
        }
    }
}
