using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {     
            if(collision.gameObject.tag=="Player")
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {     
            if(collision.gameObject.tag=="Player")
            Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update() { 
    }
}
