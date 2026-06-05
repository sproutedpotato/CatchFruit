using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{
    [SerializeField]
    private Sprite[] backgrounds;
    private Vector3 spawnPos = new Vector3(0, 0, 0);
    private Vector3 spawnPos2 = new Vector3(24f, 0, 0);
    private Vector3 spawnScale = new Vector3(10, 10, 1);
    private float moveSpeed = 3f;
    private GameObject background, background2;
    int backgroundNumber;
    // Start is called before the first frame update
    void Start()
    {
        backgroundNumber = Random.Range(0, backgrounds.Length);

        background = new GameObject("Background");

        SpriteRenderer spriteRenderer = background.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = backgrounds[backgroundNumber];
        background.transform.position = spawnPos;

        background.transform.localScale = spawnScale;

        if(backgroundNumber <= 3){
            background2 = new GameObject("Background2");

            SpriteRenderer spriteRenderer2 = background2.AddComponent<SpriteRenderer>();
            spriteRenderer2.sprite = backgrounds[backgroundNumber];

            background2.transform.position = spawnPos2;
            background2.transform.localScale = spawnScale;
        }
    }

    void Update(){
        if(backgroundNumber <= 3){
            background.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        
            if (background.transform.position.x < -24){
                background.transform.position += new Vector3(48f, 0, 0);
            }

            background2.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            if (background2.transform.position.x < -24){
                background2.transform.position += new Vector3(48f, 0, 0);
            }
        }     
    }
}
