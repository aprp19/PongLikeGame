using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    public int maxScore;
    public PaddleController playerPaddle;
    public TMP_Text gameOver;
    public BallController ball;

    public void AddLeftScore(int increment)
    {
        ball.ResetBall();
        leftScore += increment;
        if (leftScore >= maxScore)
        {
            ball.StopBall();
            gameOver.SetText("Left Win!");
            gameOver.gameObject.SetActive(true);
            Invoke("GameOver",3f);
        }
    }
    public void AddRightScore(int increment)
    {
        ball.ResetBall();
        rightScore += increment;
        if (rightScore >= maxScore)
        {
            ball.StopBall();
            gameOver.SetText("Right Win!");
            gameOver.gameObject.SetActive(true);
            Invoke("GameOver",3f);
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
