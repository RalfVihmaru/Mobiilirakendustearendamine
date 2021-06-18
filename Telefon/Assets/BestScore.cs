using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    private int maxScore;
    public Text totalScore;
    void Update()
    {
        maxScore = PlayerPrefs.GetInt("BestScore", maxScore);
        totalScore.text = "Best score: " + zombieCollision.score.ToString();
    }
}
