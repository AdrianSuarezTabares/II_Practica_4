using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; 
    public TextMeshProUGUI scoreText; 
    public TextMeshProUGUI rewardText; 

   
    public delegate void ScoreUpdated(int newScore);
    public event ScoreUpdated OnScoreUpdated; 

    private int rewardThreshold = 100;

    void Start()
    {
        UpdateScoreText(); 
        rewardText.text = ""; 
    }

    public void AddScore(int points)
    {
        score += points;  
        OnScoreUpdated?.Invoke(score);  
        UpdateScoreText();  
        CheckForReward();  
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    private void CheckForReward()
    {
        if (score > rewardThreshold)
        { 
            rewardThreshold *= 2;
            GiveReward();
        }
    }

    // Método para dar la recompensa
    private void GiveReward()
    {
        rewardText.text = "Congratulations for " + score + " points!";
    }
}
