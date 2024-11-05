using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 startPos;

    public RubyManager rm;
    public Timer tm;
    public Score sc;
    public float baseScore = 10000f; // Initial base score
    private float minScore = 1000f;  // Minimum score limit
    float time;
    float timeScore;
    float rubyMultiplier;
    float finalScore;

    private void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
        }

        if (collision.CompareTag("Ruby"))
        {
            Destroy(collision.gameObject);
            rm.rubyCount++;
        }

        if (collision.CompareTag("Score"))
        {
            // Calculate the time-based score reduction
            time = (tm.minutes * 60) + tm.seconds;
            timeScore = Mathf.Max(baseScore - (time * 30), minScore);

            // Calculate the ruby multiplier as 2^rubyCount
            rubyMultiplier = Mathf.Pow(2, rm.rubyCount);

            // Calculate the final score for the level
            finalScore = timeScore * rubyMultiplier;

            // Update the current score in the Score script
            Score.score += finalScore;

            // Check and update the high score if necessary
            sc.CheckForHighScore();
        }

        if (collision.CompareTag("Finish"))
        {
            SceneController.instance.NextLevel();
        }
    }

    void Die()
    {
        Respawn();
    }

    void Respawn()
    {
        transform.position = startPos;
    }
}
