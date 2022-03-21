using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 0.002f;
    public Vector2 direction = new Vector2(-1, 0);
    public Pause pause;

    void Update()
    {
        if (pause.terrainAvance)
        {
            Vector2 newPos = transform.position;
            newPos += direction * speed;
            transform.position = newPos;
        }
    }
}
