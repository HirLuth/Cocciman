using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoretext;

    public int startScore = 0;
    public int scoreThreshold = 100;

    public Vie vie;

    void RefreshText()
    {
        scoretext.text = "Score : " + score;
    }

    public void AddPoint(int points)
    {
        score += points;
        RefreshText();
    }

    private void Start()
    {
        RefreshText();
        startScore = score;
    }

    private void Update()
    {
        GetVieUp();
    }

    public void GetVieUp()
    {
        if (score >= startScore + scoreThreshold)
        {
            startScore = score;
            vie.AddVie();
        }
    }
}
