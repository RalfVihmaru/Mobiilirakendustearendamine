
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToTitle : MonoBehaviour
{
    public void RestartGame()
    {
        zombieCollision.score = 0;
        TurretCollision.lives = 10;
        SceneManager.LoadScene("Scene1");
    }
}