using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Script des tirs
    public Bullets bullets;
    // Fonction appelée dans le script du personnage pour instancier un tir
    public void Shoot()
    {
        GameObject go = Instantiate(bullets.gameObject, transform.position, Quaternion.identity);
    }
}
