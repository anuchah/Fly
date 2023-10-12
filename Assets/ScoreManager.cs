using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text highScoreText;
    int score = EagleScript.numberOfCoins;
    int highScore;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }

    private void Update()
    {
        score = EagleScript.numberOfCoins;
        scoreText.text = score.ToString();
        if (highScore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

}
