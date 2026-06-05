using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndSceneText : MonoBehaviour
{
    GameObject scoreText;
    GameManager manager;
    private long myScore;
    // Start is called before the first frame update
    void Start()
    {   
        this.scoreText = GameObject.Find("Score");
        manager = GameManager.Instance;
        myScore = manager.GetPrevScore();
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Your Score is "+ myScore.ToString();
    }
}
