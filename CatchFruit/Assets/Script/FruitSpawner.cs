using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] fruits;
    [SerializeField]
    private float spawnInterval;
    private int fruitNumber;
    private GameManager manager;
    private int sceneNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        StartFruitRoutine();
        manager = GameManager.Instance;
        sceneNumber = manager.GetSceneNumber();
    }

    IEnumerator FruitRoutine(){
        yield return new WaitForSeconds(3f);

        while(true){
            float PosX = Random.Range(-4f, 4f);

            if(sceneNumber == -1){
                SetFruit(PosX, 8, fruits); 
            }
            else if(sceneNumber == 0){
                SetFruit(PosX, 8, fruits);
            }
            else if(sceneNumber == 1){
                SetFruit(PosX, 7, fruits);
            }
            else if(sceneNumber == 2){
                SetFruit(PosX, 7, fruits);
            }
            else if(sceneNumber == 3){
                SetFruit(PosX, 6, fruits);
            }
            else if(sceneNumber == 4){
                SetFruit(PosX, 6, fruits);
            }
            
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void StartFruitRoutine(){
        StartCoroutine(FruitRoutine());
    }

    void spawnFruit(float pos, int index){
        Vector3 spawnPos = new Vector3(transform.position.x, pos, 0);
        Instantiate(fruits[index], spawnPos, Quaternion.identity);
    }

    private void SetFruit(float pos, int avo, GameObject[] fruits){
        int temp = Random.Range(0, avo);
        int num = Random.Range(0, fruits.Length - 1);
        if(temp == 0){
            spawnFruit(pos, fruits.Length - 1);
        }
        else{
            spawnFruit(pos, num);
        }
    }
}
