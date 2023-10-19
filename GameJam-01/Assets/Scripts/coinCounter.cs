using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinCounter : MonoBehaviour
{
    private TMP_Text displayCoins;
    // Start is called before the first frame update
    void Start()
    {
        displayCoins = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        displayCoins.text = "Coins: " + gameManager.points.ToString();   
    }
}
