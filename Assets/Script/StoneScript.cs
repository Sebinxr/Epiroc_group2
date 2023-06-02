using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScript : MonoBehaviour
{
    public int points = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Access the player's score script or manager and update the score.
            ScoreManager.Instance.AddPoints(points);

            // Destroy the stone object.
            Destroy(gameObject);
        }
    }
}

