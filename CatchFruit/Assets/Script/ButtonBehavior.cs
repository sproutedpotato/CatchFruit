using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehavoior : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    private string Scene = "FirstScene";
    public void OnClickStartButton(){
        SceneManager.LoadScene(Scene);
    }
    public void OnClickHowToPlayButton(){
        panel.SetActive(true);
    }
    public void ClickCloseButton(){
        panel.SetActive(false);
    }
    public void OnClickQuitButton(){
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void BackToTitleButton(){
        SceneManager.LoadScene("GameStart");
    }
    public void RestartButton(){
        SceneManager.LoadScene("FirstScene");
    }
}
