using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour
{
    bool inputBlock = true;
    void Start()
    {
        
    }
    void Update()
    {
        if (inputBlock) 
        { 
        }

        if (Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
            inputBlock = false;
        }
    }
}