using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPrime : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            player.transform.position, 0.003f);
    }
}