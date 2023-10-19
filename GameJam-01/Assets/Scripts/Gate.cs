using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    private bool bossResp=false;
    public int coinRequirement = 1;
    public GameObject spawnableObject;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (coinRequirement <= gameManager.points)
        {
            if (!bossResp)
            {
                Vector3 spawnPosition = new Vector3(-7.87f, 2.92f, 0f);
                Instantiate(spawnableObject, spawnPosition, Quaternion.identity);
                bossResp = true;
            }
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            
        }
    }
}
