using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public TMP_Text leftScore;
    public TMP_Text rightScore;

    public ScoreManager manager;

    private void Update()
    {
        leftScore.text = manager.leftScore.ToString();
        rightScore.text = manager.rightScore.ToString();
    }
}
