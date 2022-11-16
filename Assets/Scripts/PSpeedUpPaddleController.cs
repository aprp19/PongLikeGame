using System;
using UnityEngine;

public class PSpeedUpPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public BallController ballController;
    
    public GameObject leftPaddle;
    public GameObject rightPaddle;

    public int speedUp = 4;

    // Update is called once per frame
    void Update()
    {
        if (manager.powerUpList.Count >= 3)
        {
            manager.RemoveAfterTime(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (ballController.ballIsRight)
            {
                manager.RemovePowerUp(gameObject);
                rightPaddle.GetComponent<PaddleController>().ActivateSpeedPaddle(speedUp);
                rightPaddle.GetComponent<BotPaddleController>().ActivateSpeedPaddle(speedUp);
            }
            else
            {
                leftPaddle.GetComponent<PaddleController>().ActivateSpeedPaddle(speedUp);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}

