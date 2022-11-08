using System;
using UnityEngine;

public class PSpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;

    private void Update()
    {
        if (manager.powerUpList.Count >= 3)
        {
            Invoke("manager.RemoveAfterTime(gameObject)",3f);
            manager.RemoveAfterTime(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        { 
            ball.GetComponent<BallController>().ActivatePSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
