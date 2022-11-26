using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Square;
    public void GoToParametres()
    {
        StartCoroutine(Parametres());
    }
    void Update()
    {
        if ((Cam.transform.position.z-6f > Square.transform.position.z - Square.transform.localScale.z) && (Cam.transform.position.z-6f < Square.transform.position.z + Square.transform.localScale.z))
        {
            print("in");
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GoToParametres();
            }
        }
    }
    IEnumerator Parametres()
    {

        //Mettre le bon nom du menu

        AsyncOperation asyncload = SceneManager.LoadSceneAsync("Transition");
        while (!asyncload.isDone)
        {
            yield return null;
        }
    }
    
}
