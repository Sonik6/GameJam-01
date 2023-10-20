using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPrime : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public static float ghostSpeed;
    // Start is called before the first frame update
    void Start()
    {
        ghostSpeed = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, GameObject.Find("PlayerCharacter").transform.position, ghostSpeed);
    }
}
