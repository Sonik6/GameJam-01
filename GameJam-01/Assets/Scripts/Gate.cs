using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
   private AudioSource audioData;

    public int coinRequirement = 1;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        Debug.Log(audioData.clip);

    }

    // Update is called once per frame
    void Update()
    {
        if (coinRequirement <= gameManager.points)
        {
            audioData.Play(0);
            Destroy(gameObject);

        }
    }
}
