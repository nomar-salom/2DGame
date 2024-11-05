using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text highScoreText;  // Reference to the Text UI element for high score display
    public Score sc;

    void Start()
    {
        sc.CheckForHighScore();
        // Retrieve the high score from PlayerPrefs (default to 0 if no high score saved)
        float highScore = PlayerPrefs.GetFloat("highscore", 0);

        // Update the UI Text to show the high score
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore.ToString("F0");
        }
    }

    public void PlayGame()
    {
        Score.score = 0;
        SceneManager.LoadSceneAsync(1);
    }
    
}
