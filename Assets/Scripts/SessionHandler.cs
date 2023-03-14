using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverUI;

    public static bool gameStarted = false;
    public static bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.enabled = false;

        if (!gameStarted)
        {
            ProcessCommon();
        }

        gameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted && gameOver)
        {
            ProcessEnd();
            gameStarted = false;
            gameOver = false;
        }
    }
    public void ProcessCommon()
    {
        //Pause Game (Stop time)
        Time.timeScale = 0;

    }
    public void ProcessEnd()
    {
        gameOverUI.enabled = true;
        ProcessCommon();
    }


}
