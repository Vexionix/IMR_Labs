using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class GameScoreboard : MonoBehaviour
{
    public GameObject scoreboard;
    public TMP_Text scoreText;
    private int score = -2;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log("score");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
