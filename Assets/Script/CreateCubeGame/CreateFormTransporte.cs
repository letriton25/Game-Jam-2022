using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFormTransporte : MonoBehaviour
{

    public GameObject perso;
    public GameObject labyrinthe;

    public GameObject createGame;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            labyrinthe.SetActive(false);
            perso.SetActive(false);
            createGame.SetActive(true);
        }
    }
}
