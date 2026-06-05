using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x < -15){
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            Destroy(gameObject);       
        }
    }
}
