using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasp : MonoBehaviour
{
    public bool Up;

    public int speed = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Up)
        {
            transform.Translate(speed*Time.deltaTime,2*Time.deltaTime,0);
        }
        else
        {
            transform.Translate(speed*Time.deltaTime,-2*Time.deltaTime,0);
        }
    }

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (Up)
            {
                Up = false;
            }
            else
            {
                Up = true;
            }
        }
    }
}
