using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    private float moveSpeed = 3f;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < -19){
            transform.position += new Vector3(38f, 0, 0);
        }
    }
}
