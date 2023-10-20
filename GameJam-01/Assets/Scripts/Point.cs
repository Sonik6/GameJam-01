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
        Debug.Log(audioData);
        Debug.Log(audioData.clip);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioData.clip = Resources.Load<AudioClip>("muzyka/mixkit-retro-arcade-casino-notification-211");
            Debug.Log(audioData.clip);
            audioData.Play(0);
            
            gameManager.points = gameManager.points + 1;
            Destroy(gameObject);
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
