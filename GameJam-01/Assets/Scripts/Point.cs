using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        audioData.clip = Resources.Load();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioData.Play(0);
            Debug.Log(gameManager.points);
            gameManager.points = gameManager.points + 1;
            Destroy(gameObject);
            coinCounter.displayCoins.text = "Coins: " + gameManager.points.ToString();
            Debug.Log(gameManager.points);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
