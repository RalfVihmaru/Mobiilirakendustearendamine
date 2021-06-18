using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class zombieCollision : MonoBehaviour
{
    public static int score = 0;
    private void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Bullet(Clone)")
        {
            Destroy(col.gameObject);
            score++;
            Debug.Log(score);
        }
        
    }
    private void Update()
    {

    }
}