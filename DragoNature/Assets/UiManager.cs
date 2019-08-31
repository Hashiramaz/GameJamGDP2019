using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public GameObject finalScreen;
    public GameObject scoreInformations;

    private void Awake() {
        if(instance == null)
            instance = this;
    }

    public void EnableFinalScreen(){
        
        finalScreen.SetActive(true);
        scoreInformations.SetActive(false);
    }

    public void ReturnToMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void ResetGame(){
        GameManager.instance.ResetGame();
    }
}
