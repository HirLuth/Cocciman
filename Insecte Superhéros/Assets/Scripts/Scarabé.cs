using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarabé : MonoBehaviour
{
    public int speed = 2;
    public int speedCharge = 15;
    public float distance = 5;

    public GameObject coccinelle;
    public Vector2 positionCocci;
    public Vector2 positionScara;
    public bool charge;
    public bool retour;
    
    private void FixedUpdate()
    {
        positionCocci = coccinelle.transform.position;
        positionScara = transform.position;

        // s'effectue quand le scarabé charge
        if (charge == true)
        {
            float moveAmount = speedCharge * Time.fixedDeltaTime;
            charge = true;

            if (positionCocci.x - 1 < positionScara.x)
            {
                positionScara.x -= moveAmount;
            }
            else   
            {
                retour = true;
                charge = false;
            }
            
            transform.position = positionScara;
        }
        
        // s'effectue quand le scarabé finit sa charge
        else if (retour == true)
        {
            float moveAmount = speed * Time.fixedDeltaTime;
            
            positionScara.x += moveAmount;
            transform.position = positionScara;

            if (positionScara.x > positionCocci.x + distance) // si le scarabé est suffisament loin du joueur
            {
                retour = false;
            }
        }

        // s'effectue quand le scarabé vise le joueur
        else if (charge == false && retour == false)
        {
            float moveAmount = speed * Time.fixedDeltaTime;
            if (positionCocci.y > positionScara.y)
            {
                positionScara.y += moveAmount;
            }
        
            if (positionCocci.y < positionScara.y)
            {
                positionScara.y -= moveAmount;
            }

            transform.position = positionScara;

            if (positionCocci.y < positionScara.y + 0.1 && positionCocci.y > positionScara.y - 0.1)
            {
                StartCoroutine(AvantCharge());
            }
        }

        // s'effectue quand le scarabé prépare sa charge
        IEnumerator AvantCharge()
        {
            yield return new WaitForSeconds(0.7f);
            charge = true;
        }
    }

}
