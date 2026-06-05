using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    // 싱글톤 인스턴스를 위한 정적 필드
    private static GameManager _instance;

    // 점수를 설정할 필드
    private int score { get; set; }
    private float hp { get; set; }
    private int prevScore { get; set; }
    // OnTriggerScore 이벤트 정의
    public static Action OnTriggerScore;
    public static Action OnTriggerHeart;
    private int sceneNumber { get; set; }
    // 싱글톤 인스턴스를 가져오는 프로퍼티
    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }
    // 게임 시작 시 싱글톤 설정
    private void Awake()
    {
        // 이미 인스턴스가 존재하면, 새로 생성된 인스턴스는 삭제
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);  // 중복된 인스턴스는 제거
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);  // 씬 전환 시에도 GameManager가 파괴되지 않도록 설정
        }

        this.hp = 3f;
    }
    // 기본 생성자
    private GameManager() 
    {
        score = 0;
        sceneNumber = -1;
    }

    // 점수 가져오기
    public int GetScore()
    {
        return score;
    }

    public void ResetManager(){
        this.prevScore = score;
        this.hp = 3;
        this.score = 0;
    }

    // 점수 설정
    public void SetScore(int num = 0, string str = "")
    {
        if (str == "+") score += num;
        else if (str == "-") score -= num;

        OnTriggerScore?.Invoke();
    }

    public void SetHp(float num = 0, string str = ""){
        if(str == "+"){
            hp += num;
        }
        else if(str == "-"){
            hp -= num;
        }

        OnTriggerHeart?.Invoke();
    }

    public float GetHp(){
        return hp;
    }

    public void SetSceneNumber(int num = 0){
        this.sceneNumber = num;
    }

    public int GetSceneNumber(){
        return this.sceneNumber;
    }

    public int GetPrevScore(){
        return prevScore;
    }
}