using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    private GameObject heart_1, heart_2, heart_3;
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.Instance;
        this.heart_1 = GameObject.Find("Heart1");
        this.heart_2 = GameObject.Find("Heart2");
        this.heart_3 = GameObject.Find("Heart3");
        SetHeart();
    }

    // Update is called once per frame
    private void OnEnable()
    {
        GameManager.OnTriggerHeart += SetHeart; 
    }
    private void OnDisable()
    {
        GameManager.OnTriggerHeart -= SetHeart;
    }

    public void SetHeart(){
        switch(manager.GetHp()){
            case 3:
                if(this.heart_1.GetComponent<Image>().fillAmount == 0){
                    this.heart_1.GetComponent<Image>().fillAmount += 1;
                }
                if(this.heart_2.GetComponent<Image>().fillAmount == 0){
                    this.heart_2.GetComponent<Image>().fillAmount += 1;
                }
                if(this.heart_3.GetComponent<Image>().fillAmount == 0){
                    this.heart_3.GetComponent<Image>().fillAmount += 1;
                }
                break;
            case 2:
                if(this.heart_1.GetComponent<Image>().fillAmount == 1){
                    this.heart_1.GetComponent<Image>().fillAmount -= 1;
                }
                if(this.heart_2.GetComponent<Image>().fillAmount == 0){
                    this.heart_2.GetComponent<Image>().fillAmount += 1;
                }
                if(this.heart_3.GetComponent<Image>().fillAmount == 0){
                    this.heart_3.GetComponent<Image>().fillAmount += 1;
                }
                break;
            case 1:
                if(this.heart_1.GetComponent<Image>().fillAmount == 1){
                    this.heart_1.GetComponent<Image>().fillAmount -= 1;
                }
                if(this.heart_2.GetComponent<Image>().fillAmount == 1){
                    this.heart_2.GetComponent<Image>().fillAmount -= 1;
                }
                if(this.heart_3.GetComponent<Image>().fillAmount == 0){
                    this.heart_3.GetComponent<Image>().fillAmount += 1;
                }
                break;
            case 0:
                if(this.heart_1.GetComponent<Image>().fillAmount == 1){
                    this.heart_1.GetComponent<Image>().fillAmount -= 1;
                }
                if(this.heart_2.GetComponent<Image>().fillAmount == 1){
                    this.heart_2.GetComponent<Image>().fillAmount -= 1;
                }
                if(this.heart_3.GetComponent<Image>().fillAmount == 1){
                    this.heart_3.GetComponent<Image>().fillAmount -= 1;
                }
                break;
        }
    }
}
