using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class currentLvlDisplay : MonoBehaviour
{
    private TMP_Text currentLvlDisplay;
    //public TextMeshProUGUI displayText;
    // Start is called before the first frame update
    void Start()
    {
        currentLvlDisplay = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        currentLvlDisplay.text = "Level " + gameManager.currentLevel.ToString();
    }
}
