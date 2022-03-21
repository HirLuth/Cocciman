using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 beginPosition = new Vector3(0, 0, 0);
    public float speed = 5.0f;
    public Vie hit;
    public MenuManager mm;
    public bool shoot;
    public Gun gun;
    public BoxCollider2D invincible;
    public SpriteRenderer clignote;

    //public Transform playerPosition;
    void Start()
    {
        gameObject.transform.position = beginPosition;
    }
    
    void Update()
    {
        //GamePaused();
        Move();
        shoot = Input.GetKeyDown(KeyCode.Space);

        if (shoot)
        {
            shoot = false;
            gun.Shoot();
        } 
        

    }
    void Move()
    {

        if (Input.GetKey(KeyCode.Z) && transform.position.y <= 8)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= 0.5)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q) && transform.position.x >= -7.5)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }  
    }
    

}