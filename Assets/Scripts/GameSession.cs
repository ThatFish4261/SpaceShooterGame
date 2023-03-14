using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] public Canvas mainMenuUI;
    public bool hasReload;

    private void Update()
    {
        if (SessionHandler.gameStarted)
        {
            mainMenuUI.enabled = false;
        }

        if (hasReload)
        {
            Time.timeScale = 1;
            hasReload = false;
            print("reloaded");
        }
    }

    public void ReloadGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        SessionHandler.gameStarted = true;
        mainMenuUI.enabled = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void wowStart()
    {
        Time.timeScale = 1;
        mainMenuUI.enabled = false;
        hasReload = true;

    }

}
