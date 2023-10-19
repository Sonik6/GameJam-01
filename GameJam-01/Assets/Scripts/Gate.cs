using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public AudioClip saw;
    public int coinRequirement = 1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().clip = saw;
    }

    // Update is called once per frame
    void Update()
    {
        if (coinRequirement <= gameManager.points)
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);

        }
    }
}
