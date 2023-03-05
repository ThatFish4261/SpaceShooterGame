using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadBar : MonoBehaviour
{
    public Image reloadBar;
    public float otherFire;
    public float fireCountdown;
    
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerController.fireRate);
        otherFire = Time.time + PlayerController.nextFire;
    }

    // Update is called once per frame
    void Update()
    {
        print(otherFire);
    }
}
