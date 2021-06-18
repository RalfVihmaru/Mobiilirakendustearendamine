
using UnityEngine;
using UnityEngine.UI;
public class ScoreUpdate : MonoBehaviour
{
    public Text totalScore;
    void Update()
    {
        totalScore.text = "Total score: " + zombieCollision.score.ToString();
    }
}
