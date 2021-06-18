using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        zombieCollision.score = 0;
        TurretCollision.lives = 10;
        Cursor.visible = false;
        SceneManager.LoadScene("Scene3");
    }
}