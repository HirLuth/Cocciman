using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaraboy : MonoBehaviour
{
    [Header("Spawn")]
    public float compteurDeclenchement;  // Nombre de mouches qu'il faut tuer pour le faire apparaitre
    private bool stop;

    [Header("Comportement")] 
    public float vie;
    public float speed;
    public float hauteurMax;
    public float hauteurMin;
    private bool goDown;

    [Header("Attaque")] 
    public float frequenceAttaques;
    public float pausesEntreAttaques;
    public float cadenceDeTir;
    private int numeroAttaque;
    private float timer;
    private float timerInterne;

    [Header("Autres")] 
    public Rigidbody2D rb;
    public GestionEnnemis gestion;
    public GameObject bullets;


    private void Update()
    {
        Movements();
        Shoot();
    }

    void Movements()
    {
        if (transform.position.y > hauteurMax)
        {
            rb.velocity = new Vector2(0, -speed);
            goDown = true;
        }
        
        else if (transform.position.y < hauteurMax && transform.position.y > hauteurMin && goDown == true)
        {
            rb.velocity = new Vector2(0, -speed);
            goDown = true;
        }
        
        else if (transform.position.y < hauteurMin)
        {
            rb.velocity = new Vector2(0, speed);
            goDown = false;
        }
    }

    void Shoot()
    {
        timer += Time.deltaTime;
        if (timer > frequenceAttaques)
        {
            numeroAttaque = UnityEngine.Random.Range(0, 3);
            timer = 0;
            timerInterne = 0;
        }

        if (timer > pausesEntreAttaques)
        {
            timerInterne += Time.deltaTime;

            if (numeroAttaque == 0 && timerInterne > cadenceDeTir)
            {
                timerInterne = 0;
                Instantiate(bullets, transform.position + new Vector3(-1, -0.4f, 0), Quaternion.Euler(0, 0, 180));
            }
            
            else if (numeroAttaque == 1 && timerInterne > cadenceDeTir)
            {
                timerInterne = -0.15f;
                Instantiate(bullets, transform.position + new Vector3(-1, -0.4f, 0), Quaternion.Euler(0, 0, 200));
                Instantiate(bullets, transform.position + new Vector3(-1, -0.4f, 0), Quaternion.Euler(0, 0, 180));
                Instantiate(bullets, transform.position + new Vector3(-1, -0.4f, 0), Quaternion.Euler(0, 0, 160));
            }
            
            else if (numeroAttaque == 2 && timerInterne > 0.06f)
            {
                timerInterne = 0;
                float hauteur = UnityEngine.Random.Range(-0.2f, 0.2f);
                Instantiate(bullets, transform.position + new Vector3(-1, hauteur -0.4f, 0), Quaternion.Euler(0, 0, 180));
            }
        }
        
    }
}
