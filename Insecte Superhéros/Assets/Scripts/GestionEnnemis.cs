using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionEnnemis : MonoBehaviour
{
    public Vector2 position;
    public int compteurMouches = 0;

    public GameObject scarabé;
    public GameObject mante;
    public GameObject guepe;
    private void Update()
    {
        if (compteurMouches == 2)
        {
            Instantiate(mante, new Vector2 (17, 0.1f), Quaternion.identity);
            compteurMouches += 1;
        }

        if (compteurMouches == 6)
        {
            Instantiate(scarabé, new Vector2 (13, 10), Quaternion.identity);
            compteurMouches += 1;
        }
        
        if (compteurMouches == 10)
        {
            Instantiate(mante, new Vector2 (17, 0.1f), Quaternion.identity);
            Instantiate(guepe, new Vector2 (13, 10), Quaternion.identity);
            Instantiate(guepe, new Vector2 (13, -5), Quaternion.identity);
            compteurMouches += 1;
        }
        
        if (compteurMouches == 13)
        {
            Instantiate(mante, new Vector2 (17, 0.1f), Quaternion.identity);
            Instantiate(guepe, new Vector2 (12, 10), Quaternion.identity);
            Instantiate(guepe, new Vector2 (12, -5), Quaternion.identity);
            Instantiate(guepe, new Vector2 (12, -8), Quaternion.identity);
            Instantiate(scarabé, new Vector2 (13, 15), Quaternion.identity);
            compteurMouches += 1;
        }

        if (compteurMouches == 18)
        {
            Instantiate(scarabé, new Vector2 (13, -5), Quaternion.identity);
            Instantiate(scarabé, new Vector2 (13, 10), Quaternion.identity);
            compteurMouches += 1;
        }
        
        if (compteurMouches == 20)
        {
            Instantiate(guepe, new Vector2 (12, 10), Quaternion.identity);
            Instantiate(guepe, new Vector2 (12, -5), Quaternion.identity);
            compteurMouches += 1;
        }
    }
}
