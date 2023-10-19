using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class healthDisplay : MonoBehaviour
{
    private TMP_Text displayHealth;
    //public TextMeshProUGUI displayText;
    // Start is called before the first frame update
    void Start()
    {
        displayHealth = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        displayHealth.text = "Health: " + gameManager.health.ToString();
    }
}
