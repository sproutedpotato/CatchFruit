using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TextManager : MonoBehaviour
{
    GameObject scoreText;
    GameManager manager;

    void Start()
    {
        manager = GameManager.Instance;
        this.scoreText = GameObject.Find("Score");
        
    }
    private void OnEnable()
    {
        GameManager.OnTriggerScore += UpdateScoreText; 
    }
    private void OnDisable()
    {
        GameManager.OnTriggerScore -= UpdateScoreText;
    }
    private void UpdateScoreText(){
        this.scoreText.GetComponent<TextMeshProUGUI>().text = manager.GetScore().ToString();
    }

}
