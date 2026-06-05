using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private GameManager manager;
    private Animator animator;
    // Update is called once per frame
    void Start(){
        manager = GameManager.Instance;
        animator = GetComponent<Animator>();        
    }
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f);

        transform.position += moveTo * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy"){
            if(manager.GetHp() > 0){
                animator.SetTrigger("Damage");
            }
            manager.SetHp(1f, "-");
            if (manager.GetHp() < 0){
                animator.SetTrigger("Death");
                manager.ResetManager();
            }         
        }
    }

    public void DestroyPlayer(){
        Destroy(gameObject);
    }

    public void LoadGameOverScene(){
        SceneManager.LoadScene("GameOver"); 
    }
}
