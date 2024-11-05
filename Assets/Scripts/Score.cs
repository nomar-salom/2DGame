using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float score;
    public float highscore;
    public Text scoreText;
    public Text highscoreText;    
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Total Score: " + score.ToString();
    }

    public void CheckForHighScore()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetFloat("highscore", highscore);
            PlayerPrefs.Save();
        }
    }
}
