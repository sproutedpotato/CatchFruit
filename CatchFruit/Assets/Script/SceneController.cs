using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    private string[] SceneName = {"SecondScene", "ThirdScene", "FourthScene", "FifthScene", "SixthScene"};
    private int score, sceneNumber;
    private GameManager manager;

    void Start(){
        manager = GameManager.Instance;
    }
    private void OnEnable()
    {
        // ScoreManager의 점수 변경 이벤트 구독
        GameManager.OnTriggerScore += ChangeScene;
    }

    private void OnDisable()
    {
        // 점수 변경 이벤트 구독 해제
        GameManager.OnTriggerScore -= ChangeScene;
    }

    private void ChangeScene(){
        score = manager.GetScore();
        sceneNumber = manager.GetSceneNumber();

        if(score > 1000 && score <= 5000 && sceneNumber == -1)  ControllScene(0);  
        else if(score > 5000 && score <= 13000 && sceneNumber == 0)  ControllScene(1);
        else if(score > 13000 && score <= 25000 && sceneNumber == 1)  ControllScene(2);
        else if(score > 25000 && score <= 40000 && sceneNumber == 2)  ControllScene(3);
        else if(score > 40000 && score <= 70000 && sceneNumber == 3)  ControllScene(4);
    }

    private void ControllScene(int num){
        manager.SetSceneNumber(num);
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName[num]); 
    }
}
