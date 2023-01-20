using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerController : MonoBehaviour
{
    public GameObject game;
    //public GameObject arrow;
    //private GameObject player = GameObject.FindGameObjectWithTag("Player");
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("trigger");
            //SceneManager.LoadScene("Temp", LoadSceneMode.Single);
            game.SetActive(true);
            //arrow.SetActive(false);
            //Debug.Log(this);
            Destroy(gameObject);
        }
    }
}
