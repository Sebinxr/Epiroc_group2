using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; } // Static instance of the ScoreManager.

    private int score = 0; // Variable to store the score.

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // Assign the instance to the first created ScoreManager.
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances of ScoreManager.
        }
    }

    // Implement methods to modify the score.
    // For example, let's implement a method to add points to the score:
    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        // You can perform any additional actions related to scoring here.
    }

    // Implement other methods as per your scoring requirements.

    // You can also add a method to retrieve the current score if needed:
    public int GetScore()
    {
        return score;
    }
}
