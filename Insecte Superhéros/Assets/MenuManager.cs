using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.WSA;
using Application = UnityEngine.Application;

public class MenuManager : MonoBehaviour
{
    public GameObject menuPrincipal;

    public GameObject menuVictoire;
    public GameObject menuDefaite;
    public bool lose;

    public int compteurArthur;

    void Start()
    {
        
    }

    void Update()
    {
        Stop();
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("ça quit");
    }

    public void VerifPlay()
    {
        Debug.Log("on joue");
    }

    public void Stop()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Time.timeScale = 0;
            Debug.Log("ça stop");
            menuPrincipal.SetActive(true);
        }
    }

    public void Win()
    {

            Time.timeScale = 0;
            menuVictoire.SetActive(true);
    }

    public void Lose()
    {
        if (lose == true)
        {
            Time.timeScale = 0;
            menuDefaite.SetActive(true);
        }

    }
}