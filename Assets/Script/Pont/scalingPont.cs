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
        pont.transform.localScale = new Vector3(
            pont.transform.localScale.x + scalingSpeed * scalingCoef * Input.GetAxis("Scale") * Time.deltaTime,
            pont.transform.localScale.y,
            pont.transform.localScale.z
        );
        if(pont.transform.localScale.x <= 0)
            pont.transform.localScale = new Vector3(0, pont.transform.localScale.y, pont.transform.localScale.z);
    }
}