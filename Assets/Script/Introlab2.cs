using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introlab2 : MonoBehaviour
{
    public GameObject camintro;
    public GameObject camMain;
    //public Canvas minigame;
    
    // Start is called before the first frame update
    void Start()
    {
        camintro.SetActive(true);
        camMain.SetActive(false);
        //minigame.gameObject.SetActive(false);
        delay();
    }


    private void delay()
    {
        StartCoroutine(subdelay());
    }
    
    public IEnumerator subdelay()
    {
        yield return new WaitForSeconds(3.5f);
        camintro.SetActive(false);
        camMain.SetActive(true);
        //minigame.gameObject.SetActive(true);
    }
}
