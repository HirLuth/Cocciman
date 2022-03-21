using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public bool explode = false;
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(Explode());
    }

    // Update is called once per frame
    void Update()
    {
        if (explode == true)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Explode()
    {
        yield return new WaitForSeconds(0.3f);
        explode = true;
    }
}
