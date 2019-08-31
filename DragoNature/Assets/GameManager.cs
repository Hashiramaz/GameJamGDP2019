using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isPlaying;
    public static GameManager instance;
    private void Awake() {
        if(instance == null)
            instance = this;
    }

    private void Start() {
        StartGame();
    }
    public void StartGame(){
        isPlaying = true;
        AudioManager.instance.Play("GameMusic");
    }

    public void StopGame(){
        
        isPlaying = false;
        Debug.Log("STOPPED GAME");
        UiManager.instance.EnableFinalScreen();
    }

    public void ResetGame(){
        SceneManager.LoadScene("Game");

    }
}
