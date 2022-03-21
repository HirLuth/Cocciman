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
    public Pause pause;

    public int compteurArthur;

    void Start()
    {
        Stop();        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Stop();
        }
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
        Time.timeScale = 0;
        pause.terrainAvance = false;
            Debug.Log("ça stop");
            menuPrincipal.SetActive(true);
    }

    public void Win()
    {

            Time.timeScale = 0;
            pause.terrainAvance = false;
            menuVictoire.SetActive(true);
    }

    public void Lose()
    {
        if (lose)
        {
            Time.timeScale = 0;
            pause.terrainAvance = false;
            menuDefaite.SetActive(true);
        }

    }
}