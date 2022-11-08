using UnityEngine;

public class BotPaddleController : MonoBehaviour
{
    public GameObject ball;
    public float speed;
    public float lerpSpeed;
    private Rigidbody2D rig;
 
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
}
