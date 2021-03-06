using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piques : MonoBehaviour
{
    public Vector2 direction = new Vector2(-1, 0);
    public float speed = 2;
    public Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 8);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, 8);
        Debug.Log("hit");
        //Là faudrait faire appelle à une fonction dans les ennemis qui lancent l'animation d'explosion
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * speed;
    }

    void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }
}
