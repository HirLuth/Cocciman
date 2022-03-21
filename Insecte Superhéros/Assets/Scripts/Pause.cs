using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pause : MonoBehaviour
{
    // Bouton reprendre, hesites pas à ajouter des trucs qui apparaitraint quand on met pause
    public GameObject pauseText;

    public bool terrainAvance = false;

    private void Start()
    {
    GetPause();
    }

    private void Update()
    {
        // On fait apparaitre le bouton et stop le temps ZA WARUDOOOOO
        if (Input.GetKey(KeyCode.P))
        {
            GetPause();
            pauseText.SetActive(true);
        }
    }

    public void GetPause()
    {
        Time.timeScale = 0;
        terrainAvance = false;
    }

    public void OnPause()
    {
        pauseText.SetActive(false);
        terrainAvance = true;
        Time.timeScale = 1;
    }
}