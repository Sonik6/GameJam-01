using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
<<<<<<< Updated upstream
   private AudioSource audioData;

=======
    private AudioSource audioData;
    private bool bossResp=false;
>>>>>>> Stashed changes
    public int coinRequirement = 1;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GameObject.Find("Main Camera").GetComponent<AudioSource>();
<<<<<<< Updated upstream
        Debug.Log(audioData.clip);
=======
>>>>>>> Stashed changes

    }

    // Update is called once per frame
    void Update()
    {
        if (coinRequirement <= gameManager.points)
        {
<<<<<<< Updated upstream
            audioData.Play(0);
=======
            audioData.clip = Resources.Load<AudioClip>("muzyka/gate");
            audioData.Play();

            if (!bossResp)
            {
                Vector3 spawnPosition = new Vector3(-7.87f, 2.92f, 0f);
                Instantiate(spawnableObject, spawnPosition, Quaternion.identity);
                bossResp = true;
            }
            GetComponent<AudioSource>().Play();
>>>>>>> Stashed changes
            Destroy(gameObject);

        }
    }
}
