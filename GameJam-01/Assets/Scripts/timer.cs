using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class timer : MonoBehaviour
{
    private string timeString;
    private string minutes;
    private string seconds;
    public static TMP_Text displayTime;
    // Start is called before the first frame update
    void Start()
    {
        displayTime = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameManager.timer > 59.99)
        {
            minutes = Math.Round((Math.Round(gameManager.timer, 0) / 60), 0).ToString();
            seconds = (Math.Round(gameManager.timer, 0) % 60).ToString();
            if (int.Parse(seconds)<10)
            {
                timeString = minutes + ":0" + seconds;
            }
            else
            {
                timeString = minutes + ":" + seconds;
            }
            
            Debug.Log(timeString);
            timer.displayTime.text = "Time: " + timeString;

        }
        else 
        {
            if (Math.Round(gameManager.timer, 0)<10)
            {
                timer.displayTime.text = "Time: 0:0" + (Math.Round(gameManager.timer, 0)).ToString();
            }
            else
            {
                timer.displayTime.text = "Time: 0:" + (Math.Round(gameManager.timer, 0)).ToString();
            }
            

        }
        
    }
}
