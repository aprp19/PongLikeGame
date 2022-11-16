using UnityEngine;

public class BotPaddleController : MonoBehaviour
{
    public GameObject ball;
    public float speed;
    public float lerpSpeed;
    private Rigidbody2D rig;

    private Vector3 objectScale;
 
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
   
    void FixedUpdate () {
        if (ball.transform.position.y > transform.position.y)
        {
            if (rig.velocity.y < 0) rig.velocity = Vector2.zero;
            rig.velocity = Vector2.Lerp(rig.velocity, Vector2.up * speed, lerpSpeed * Time.deltaTime);
        }
        else if (ball.transform.position.y < transform.position.y)
        {
            if (rig.velocity.y > 0) rig.velocity = Vector2.zero;
            rig.velocity = Vector2.Lerp(rig.velocity, Vector2.down * speed, lerpSpeed * Time.deltaTime);
        }
        else
        {
            rig.velocity = Vector2.Lerp(rig.velocity, Vector2.zero * speed, lerpSpeed * Time.deltaTime);
        }
    }
    public void ActivateLongPaddle(int doubleSize)
    {
        objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x, objectScale.y + doubleSize, objectScale.z);
        Invoke("DeactivateLongPaddle", 5);
    }

    public void DeactivateLongPaddle()
    {
        objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x, objectScale.y - 2, objectScale.z);
    }

    public void ActivateSpeedPaddle(int speedUp)
    {
        speed += speedUp;
        Debug.Log("Speed Up: " + rig.velocity);
        Invoke("DeactivateSpeedPaddle", 5);
    }

    public void DeactivateSpeedPaddle()
    {
        speed -= 4;
        Debug.Log("Speed Reset: " + rig.velocity);
    }
}
