using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scor : MonoBehaviour
{
    public static Scor instance;
    public Text scoreText;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
    }
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";
    }
}
