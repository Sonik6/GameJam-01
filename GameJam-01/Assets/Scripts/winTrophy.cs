using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTrophy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == GameObject.Find("PlayerCharacter"))
        {
            gameManager.Win(); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
