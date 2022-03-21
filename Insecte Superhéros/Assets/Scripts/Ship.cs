using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed = 5.0f;

    public bool shoot;
    public Gun gun;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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

 /*   private void FixedUpdate() 
    {
        Vector2 pos = transform.position;

        float moveAmount = moveSpeed * Time.fixedDeltaTime;

        if (speedUp)
        {
            moveAmount *= 2;
        }

        Vector2 move = Vector2.zero;

        if (moveUp)
        {
            move.y += moveAmount;
        }

        if (moveDown)
        {
            move.y -= moveAmount;
        }

        if (moveLeft)
        {
            move.x -= moveAmount;
        }

        if (moveRight)
        {
            move.x += moveAmount;
        }

        float moveMagnitude = Mathf.Sqrt(move.x * move.x + move.y * move.y);
        Debug.Log(moveMagnitude);
        if (moveMagnitude > moveAmount)
        {
            float ratio = moveAmount / moveMagnitude;
            move *= ratio;
        }

        pos += move;

        transform.position = pos;
    } 
    */
}