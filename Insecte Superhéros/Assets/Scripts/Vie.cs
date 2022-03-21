using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using TMPro;
using UnityEngine.WSA;

public class Vie : MonoBehaviour
{
    public int vie = 1;
    public TextMeshProUGUI vieText;
    public int startVie = 1;
    public Pause pause;

    public Animation animTakeHit;
    public Animation animDeathCocciman;

    public AudioSource audioDeathCocciman;

    public MenuManager menuManager;

    void Start()
    {
        //vieText.text = "" + startVie;
    }

    void Update()
    {
        if (vie > 99)
        {
            vieText.text = "99+";
        }
        else
        {
            RefreshTextVie();
        }

        if (vie == 0)
        {
            GameOver();
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        //script de quand on subit des dégâts
        Debug.Log("aïe");
        ReduceVie();
        animTakeHit.Play();
    }

    void RefreshTextVie()
    {
        //vieText.text = "" + vie;
    }

    public void AddVie()
    {
        vie += 1;
        if (vie > 99)
        {
            vieText.text = "99+";
            Debug.Log("Vie +1 à 99+ (" + vie + ")");
        }
        else
        {
            vieText.text = "" + vie;
            Debug.Log("Vie +1");
        }
    }

    public void ReduceVie()
    {
        vie -= 1;
        if (vie > 99)
        {
            vieText.text = "99+";
            Debug.Log("Vie -1 à 99+ (" + vie + ")");
        }
        else
        {
            vieText.text = "" + vie;
            Debug.Log("Vie -1");
        }
    }

    public void GameOver()
    {
        pause.terrainAvance = false;
        animDeathCocciman.Play();
            audioDeathCocciman.Play();
            menuManager.Lose();
    }
}