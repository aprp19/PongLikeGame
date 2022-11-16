using System.Collections;
using TMPro;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public ScoreManager manager;
    public BallController ballController;
    public TMP_Text goalInfo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isRight)
            {
                manager.AddRightScore(1);
                ballController.DeActivatePSpeedUp();
                Time.timeScale = 0f;
                StartCoroutine(GoalInfo("Right Side"));
            }
            else
            {
                manager.AddLeftScore(1);
                ballController.DeActivatePSpeedUp();
                Time.timeScale = 0f;
                StartCoroutine(GoalInfo("Left Side"));
            }
        }
    }

    IEnumerator GoalInfo(string goalSide)
    {
        if (manager.leftScore >= manager.maxScore || manager.rightScore >= manager.maxScore)
        {
            Time.timeScale = 1f;
        }
        else
        {
            goalInfo.SetText(goalSide + " Scored!");
            goalInfo.gameObject.SetActive(true);
            yield return new WaitForSecondsRealtime(3);
            Time.timeScale = 1f;
            goalInfo.gameObject.SetActive(false);
        }
    }
}
