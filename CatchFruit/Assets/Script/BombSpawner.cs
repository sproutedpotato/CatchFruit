using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject bomb;

    [SerializeField]
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartBombRoutine();
    }

    // Update is called once per frame
    IEnumerator BombRoutine(){
        yield return new WaitForSeconds(3f);

        while(true){
            float PosX = Random.Range(-4f, 4f);

            spawnBomb(PosX);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void StartBombRoutine(){
        StartCoroutine(BombRoutine());
    }

    void spawnBomb(float pos){
        Vector3 spawnPos = new Vector3(transform.position.x, pos, 0);
        Instantiate(bomb, spawnPos, Quaternion.identity);
    }
}
