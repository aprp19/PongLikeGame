using System.Collections;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;
    private Vector3 objectScale;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        //Input Key
        if (Input.GetKey(upKey))
        {
            //Go Up
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            //Go Down
            return Vector2.down * speed;
        }
        
        return Vector2.zero;
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

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Paddle Speed: " + movement);
        rig.velocity = movement;
    }
}
