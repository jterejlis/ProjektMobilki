using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScreen", LoadSceneMode.Single);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
        Debug.Log("Click");
    }

    public void AuthorsScreen()
    {
        SceneManager.LoadScene("AuthorsScreen", LoadSceneMode.Single);
        Debug.Log("Click");
    }

    public void SettingsScreen()
    {
        SceneManager.LoadScene("SettingsScreen", LoadSceneMode.Single);
        Debug.Log("Click");
    }

    public void HSScreen()
    {
        SceneManager.LoadScene("HighScoreScreen", LoadSceneMode.Single);
        Debug.Log("Click");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exiting! Bye Bye");
    }
}
