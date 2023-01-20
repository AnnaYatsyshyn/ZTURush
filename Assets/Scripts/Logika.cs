using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logika : MonoBehaviour
{
    public GameObject correct;
    public GameObject wrong;
    public GameObject task;
    public GameObject input;
    public string answer;
    private string txt;

    public int kilk_kvest = 5;

    private void Update()
    {
        if (correct.activeSelf == true)
        {
            kilk_kvest -= 1;
        }
        
    }

    public void AnsYes()
    {
        Debug.Log("Ok");
        correct.SetActive(true);
        Destroy(task, 3);



        //correct.SetActive(false);
    }
    public void AnsNo()
    {
        Debug.Log("Minus life");
        wrong.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<HealthController>().health -= 1;
        //wrong.SetActive(false);
        Destroy(task, 3);
    }

    public void Check()
    {
        txt = input.GetComponent<Text>().text;
        if (txt == answer)
        {
            correct.SetActive(true);
            Destroy(task, 3);
        }
        else
        {
            wrong.SetActive(true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<HealthController>().health -= 1;
            Destroy(task, 3);
        }
    }
}
