using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.Events;

public class enemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    public int movingSpeed = 200;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector2(movingSpeed, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "wall")
        {
            rb.AddForce(new Vector2(movingSpeed * -1, 0));
            Debug.Log("hit");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.playerDamage.Invoke();
            gameManager.health--;
            gameManager.Death();
            Debug.Log("player health" + gameManager.health);
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
