using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private int score;
    private GameManager manager;
    private bool isAvocado;
    public enum FruitType
    {
        Apple, Avocado, BlueBerry, Cherry, Coconut, BlueGrape, GreenGrape, RedGrape, GrapeFruit,
        Kiwi, WaterMelon, GreenPear, YellowPear, PineApple, RedBerry, StrawBerry, YellowApple, GreenApple,
        Banana, Orange, Peach, Mango
    }
    [SerializeField]
    private FruitType fruitType;
    // Update is called once per frame
    void Start(){
        manager = GameManager.Instance;
        isAvocado = false;
    }
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x < -15){
            Destroy(gameObject);
        }
    }
    private void FruitScore(GameManager manager){
        if(fruitType == FruitType.Apple){
            score = 100;
        }
        else if(fruitType == FruitType.GreenApple){
            score = 120;
        }
        else if(fruitType == FruitType.YellowApple){
            score = 150;
        }
        else if(fruitType == FruitType.Banana){
            score = 300;
        }
        else if(fruitType == FruitType.Orange){
            score = 350;
        }
        else if(fruitType == FruitType.Peach){
            score = 400;
        }
        else if(fruitType == FruitType.Mango){
            score = 450;
        }
        else if(fruitType == FruitType.BlueBerry){
            score += 600;
        }
        else if(fruitType == FruitType.RedBerry){
            score += 700;
        }
        else if(fruitType == FruitType.BlueGrape){
            score += 1000;
        }
        else if(fruitType == FruitType.GreenGrape){
            score += 1100;
        }
        else if(fruitType == FruitType.RedGrape){
            score += 1200;
        }
        else if(fruitType == FruitType.GrapeFruit){
            score += 1500;
        }
        else if(fruitType == FruitType.PineApple){
            score += 1600;
        }
        else if(fruitType == FruitType.StrawBerry){
            score += 1700;
        }
        else if(fruitType == FruitType.Coconut){
            score += 1800;
        }
        else if(fruitType == FruitType.Kiwi){
            score += 2000;
        }
        else if(fruitType == FruitType.WaterMelon){
            score += 2130;
        }
        else if(fruitType == FruitType.Cherry){
            score += 2250;
        }
        else if(fruitType == FruitType.GreenPear){
            score += 3000;
        }
        else if(fruitType == FruitType.YellowPear){
            score += 3200;
        }
        else if(fruitType == FruitType.Avocado){
            score += 0;
            isAvocado = true;
        }

        manager.SetScore(score, "+");
        if(isAvocado && manager.GetHp() < 3){
            manager.SetHp(1, "+");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            FruitScore(manager);
            Destroy(gameObject);           
        }
    }
}
