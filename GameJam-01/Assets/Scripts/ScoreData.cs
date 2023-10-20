using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ScoreData
{
    public List<Score> times;

    public ScoreData()
    {
        times = new List<Score>();
    }
}
