using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    public int movingSpeedVertical = 200;
    public int movingSpeedHorizontal = 200;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(movingSpeedHorizontal, movingSpeedVertical));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);

        if (collision.gameObject.tag == "wall")
        {
            rb.AddForce(new Vector2(movingSpeedHorizontal * -1, movingSpeedVertical * -1));
            Debug.Log("hit");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
