using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Score : MonoBehaviour
{
    public string name;
    public float time;

    public Score(string name, float time)
    {
        this.name = name;
        this.time = time;
    }
}
