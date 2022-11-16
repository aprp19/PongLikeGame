using System;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private Rigidbody2D rig;
    public Vector2 speed;
    public Vector2 resetPosition;

    public bool ballIsRight;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Left Paddle")
        {
            ballIsRight = false;
        }
        else if (collision.gameObject.name == "Right Paddle")
        {
            ballIsRight = true;
        }
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void UnpausedBall()
    {
        rig.velocity = speed;
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public void DeActivatePSpeedUp()
    {
        rig.velocity = speed ;
    }
    
    public void StopBall()
    {
        Destroy(gameObject);
    }
}
