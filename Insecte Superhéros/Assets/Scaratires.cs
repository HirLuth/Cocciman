using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaratires : MonoBehaviour
{
    public float speed = 2;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 8);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed;
    }
}
