using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinCounter : MonoBehaviour
{
    public static TMP_Text displayCoins;

    // Start is called before the first frame update
    void Start()
    {
        displayCoins = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
