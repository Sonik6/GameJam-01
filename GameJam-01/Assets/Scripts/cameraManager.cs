using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform targetToFollow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3
        (
            transform.position.x,
            Math.Clamp(targetToFollow.position.y, 0f, 10f),
            transform.position.z
        );
    }
}
