using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerExit : MonoBehaviour
{
    public GameObject perso;
    public GameObject labyrinthe;
    public GameObject pontGame;
    public GameObject door;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            perso.SetActive(true);
            labyrinthe.SetActive(true);
            pontGame.SetActive(false);
            
            door.SetActive(false);
        }
            
    }
}
