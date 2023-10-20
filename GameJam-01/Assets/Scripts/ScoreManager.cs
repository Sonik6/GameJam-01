using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreMenager : MonoBehaviour
{
    private ScoreData sd;
    void Awake()
    {

        var json = PlayerPrefs.GetString("times", "{}");
        sd = JsonUtility.FromJson<ScoreData>(json);
       
    }

    public IEnumerable<Score> GetHighScores()
    {
        return sd.times.OrderBy(keySelector:x =>x.time);
    }

    public void AddScore(Score time)
    {
        sd.times.Add(time);
    }
    private void OnDestroy()
    {
        SaveTimes();
    }

    public void SaveTimes()
    {
        var json = JsonUtility.ToJson(sd);
        PlayerPrefs.SetString("Times", json);
    }
}
