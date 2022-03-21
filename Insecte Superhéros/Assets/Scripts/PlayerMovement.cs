using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 beginPosition = new Vector3(0, 0, 0);
    public float speed = 5.0f;
    public Animation anim;
    public bool pauseGame = false;
    public Vie hit;
    public MenuManager mm;

    //public Transform playerPosition;
    void Start()
    {
        gameObject.transform.position = beginPosition;
    }
    
    void Update()
    {
        GamePaused();
        Move();

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
    void GamePaused()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseGame = true;
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            pauseGame = false;
        }
        if (pauseGame == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("aie");
        hit.GameOver();
        mm.Lose();
    }
}