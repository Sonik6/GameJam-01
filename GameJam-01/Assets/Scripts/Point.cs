using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private AudioSource audioData;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        audioData = GameObject.Find("Main Camera").GetComponent<AudioSource>();
<<<<<<< Updated upstream
        audioData.clip = Resources.Load();
=======
        Debug.Log(audioData.clip);
>>>>>>> Stashed changes
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
<<<<<<< Updated upstream
            audioData.Play(0);
=======
            audioData.clip = Resources.Load<AudioClip>("muzyka/mixkit-retro-arcade-casino-notification-211");
            Debug.Log(audioData.clip);
            audioData.Play();
            
>>>>>>> Stashed changes
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
