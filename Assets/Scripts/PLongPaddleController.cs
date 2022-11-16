using UnityEngine;

public class PLongPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public BallController ballController;
    
    public GameObject leftPaddle;
    public GameObject rightPaddle;

    public int doubleSize = 2;

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
                rightPaddle.GetComponent<PaddleController>().ActivateLongPaddle(doubleSize);
                rightPaddle.GetComponent<BotPaddleController>().ActivateLongPaddle(doubleSize);
            }
            else
            {
                leftPaddle.GetComponent<PaddleController>().ActivateLongPaddle(doubleSize);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
