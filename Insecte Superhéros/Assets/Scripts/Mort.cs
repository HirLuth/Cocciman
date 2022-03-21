using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Mort : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GestionEnnemis gestion;
    public int points = 10;
    public Animator anim;
    public GameObject explosion;
    public MenuManager win;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("bullet"))
        {
            
            if (tag == "mouche")
            {
                gestion.compteurMouches += 1;
            }
            Destroy(gameObject);
            Destroy(collision.gameObject);
            scoreManager.AddPoint(points);
            explosion = Instantiate(explosion, transform.position, Quaternion.identity);
        }
        if(gestion.compteurMouches >= 21)
        {
            Debug.Log("ILS SONT TOUS MORTS");
            win.Win();
        }
    }
}

