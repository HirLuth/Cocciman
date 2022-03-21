using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public Vector2 direction = new Vector2(1, 0);
    public float speed = 2;
    public Vector2 velocity;
    public Scaraboy scaraboy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(scaraboy.compteurBoss);
        if (other.gameObject.tag != "Boss" || scaraboy.compteurBoss > 15)
        {
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(gameObject);
            scaraboy.compteurBoss += 1;
        }
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
