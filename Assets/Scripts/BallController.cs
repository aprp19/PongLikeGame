using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{

    private Rigidbody2D rig;
    public Vector2 speed;
    public Vector2 resetPosition;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
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
