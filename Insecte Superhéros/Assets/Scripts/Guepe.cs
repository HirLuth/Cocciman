using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guepe : MonoBehaviour
{
    public int speed = 2;
    public float distance = 5;

    public Vector2 positionCocci;
    public Vector2 positionG;
    public bool face;
    public bool cooldown;
    public Transform piquePos;

    public GameObject coccinelle;
    public Piques piques;

    private void FixedUpdate()
    {
        positionCocci = coccinelle.transform.position;
        positionG = transform.position;

        if (face == false && cooldown == false)
        {
            float moveAmount = speed * Time.fixedDeltaTime;

            if (positionCocci.y > positionG.y)
            {
                positionG.y += moveAmount;
            }

            if (positionCocci.y < positionG.y)
            {
                positionG.y -= moveAmount;
            }

            transform.position = positionG;

            if (positionCocci.y < positionG.y + 0.1 && positionCocci.y > positionG.y - 0.1)
            {
                face = true;
            }
        }

        else if(cooldown == false)
        {
            GameObject go = Instantiate(piques.gameObject, transform.position, Quaternion.identity);
            StartCoroutine(Cooldown());
            cooldown = true;
            face = false;
        }


        IEnumerator Cooldown()
        {
            yield return new WaitForSeconds(2f);
            cooldown = false;
        }
    }
}