using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthUpdate : MonoBehaviour
{

    public Text totalHealth;
    void Update()
    {
        totalHealth.text = "Lives left: " + TurretCollision.lives.ToString();
        if(TurretCollision.lives <= 0)
        {
            TurretCollision.lives = 0;
            Cursor.visible = true;
            StopGame();
        }
    }

    public void StopGame()
    {
        SceneManager.LoadScene("Scene4");

    }
}
