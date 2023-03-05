using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverUi;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUi.enabled = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ProcessEnd()
    {
        gameOverUi.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
