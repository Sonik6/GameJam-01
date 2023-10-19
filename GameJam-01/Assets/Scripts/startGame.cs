using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {


        if (Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
        }
    }
}