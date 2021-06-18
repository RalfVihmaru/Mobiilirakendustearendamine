using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TurretCollision : MonoBehaviour
{
    private void Start()
    {

    }


    public static int lives = 10;
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collision name = " + col.gameObject.name);
        if (col.gameObject.name == "zombie(Clone)")
        {
            Destroy(col.gameObject);
            lives--;
            Debug.Log(lives);
        }
    }
}