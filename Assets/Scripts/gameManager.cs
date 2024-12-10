using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    private GameObject gameOverScreen;
    private GameObject main;

    void Start(){
    //gameOverScreen = GameObject.Find("GameOverScreen");
    //gameOverScreen.SetActive(false);
    
    }

    public void GameOver(){
        SceneManager.LoadScene("GameOverScene", LoadSceneMode.Additive);
    }
}
