using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text text;
    private int tempScore;
    public static int pointsAdd;
    
    void start()
    {
        
        text = GetComponent<Text>();
        score = 0;

    }
    void Update()
    {
        if (score < 0)
        {
            score = 0;
        }
        text.text = "" + score;
        if (HealthManager.playerHealth <= 0)
        {
            score = 0;
        }

        
    }
    public static void AddPoints ()
    {
        score += pointsAdd;
        
    }
    public static void Reset()
    {
        score = 0;
    }
        
}



