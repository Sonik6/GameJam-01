using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class theVoid : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Entered collision with " + collision.gameObject.name);
        gameManager.Death();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
