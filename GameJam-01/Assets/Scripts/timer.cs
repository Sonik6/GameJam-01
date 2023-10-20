using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class timer : MonoBehaviour
{
    public static TMP_Text displayTime;
    // Start is called before the first frame update
    void Start()
    {
        displayTime = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer.displayTime.text = "Time: " + Math.Round(gameManager.timer, 2);
    }
}
