using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public float health;
    public int heartsNumber;
    public Image[] lives;
    public Sprite fullLife;
    public Sprite emptyLife;
    
    void Update()
    {
        if (health > heartsNumber)
        {
            health = heartsNumber;
        }
        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = fullLife;
            }
            else
            {
                lives[i].sprite = emptyLife;
            }
            if (i < heartsNumber)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }
}
