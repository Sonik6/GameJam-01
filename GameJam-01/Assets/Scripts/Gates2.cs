using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates2 : MonoBehaviour
{
    private AudioSource audioData;
    public int coinRequirement = 6;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GameObject.Find("Main Camera").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (coinRequirement <= gameManager.points)
        {
            audioData.clip = Resources.Load<AudioClip>("muzyka/gate");
            audioData.Play(0);

            Destroy(gameObject);

        }

    }
}
