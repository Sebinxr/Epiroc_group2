using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScript : MonoBehaviour
{
    public int points = 10;
    public AudioClip collectSound; // The audio clip for the collect sound effect

    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        // Get the AudioSource component attached to the same game object
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Access the player's score script or manager and update the score
            ScoreManager.Instance.AddPoints(points);

            // Play the collect sound effect
            PlayCollectSound();

            // Destroy the stone object
            Destroy(gameObject);
        }
    }

    private void PlayCollectSound()
    {
        // Check if an audio clip is assigned and there is an AudioSource component
        if (collectSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(collectSound);
        }
    }
}
