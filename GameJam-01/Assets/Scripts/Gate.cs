using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private AudioSource audioData;
    private bool bossResp=false;
    public int coinRequirement = 1;
    public GameObject spawnableObject;
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

            if (!bossResp)
            {
                Vector3 spawnPosition = new Vector3(-7.87f, 2.92f, 0f);
                Instantiate(spawnableObject, spawnPosition, Quaternion.identity);
                bossResp = true;
            }
            Destroy(gameObject);
            
        }
    }
}
