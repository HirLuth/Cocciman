using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mantis : MonoBehaviour
{
    public float speed = 5;
    public GameObject coccinelle;
    public Vector2 positionCocci;

    public bool saut = false;
    public bool descend = false;
    
    public float speedA = 0.002f;
    public Vector2 direction = new Vector2(-1, 0);

    void Start()
    {
        //StartCoroutine(Saut());
    }

    void Update()
    {
        if (saut == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.y >= positionCocci.y)
            {
                saut = false;
                StartCoroutine(Descend());
            }
        }

        if (saut == false && descend == true)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        
        Vector2 newPos = transform.position;
        newPos += direction * speedA;
        transform.position = newPos;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.tag == "player")
        {
            saut = true;
        }
    }

    // Update is called once per frame
    IEnumerator Saut()
    {
        yield return new WaitForSeconds(3f);
        saut = true;
    }

    IEnumerator Descend()
    {
        yield return new WaitForSeconds(1f);
        descend = true;

    }
}
