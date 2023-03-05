using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthDisplay : MonoBehaviour
{

    public Text healthText;
    public PlayerController player;

    void Update()
    {
        healthText.text = "Health: " + PlayerController.playerHealth.ToString();
    }
}
