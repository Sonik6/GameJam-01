using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTrophy : MonoBehaviour
{
    Renderer test;
    // Start is called before the first frame update
    void Start()
    {
        test = GetComponent<SpriteRenderer>();
        test.enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject == GameObject.Find("PlayerCharacter") && gameManager.points >= 10)
        {
            gameManager.Win(); 
            gameManager.trophyIsWon = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (gameManager.points >= 10)
        {
            test.enabled = true;
        }
    }
}
