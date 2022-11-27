using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalingPont : MonoBehaviour
{
    private const float scalingSpeed = 4f;

    public int scalingCoef = 0;
    public GameObject pont;

    void Update()
    {
        pont.transform.localScale = new Vector3(pont.transform.localScale.x + scalingSpeed * scalingCoef * Input.GetAxis("Scale") * Time.deltaTime, 1, 1);
        if(pont.transform.localScale.x <= 0)
            pont.transform.localScale = new Vector3(0, 1, 1);
    }
}