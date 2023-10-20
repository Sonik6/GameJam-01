using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreUi : MonoBehaviour
{
    // Start is called before the first frame update
    public RowUi rowUi;
    public ScoreMenager scoreManager;

    

    private void Start()
    {
        scoreManager.AddScore(new Score("Marcin", 200));
        scoreManager.AddScore(new Score("Pawel", 400));
        scoreManager.AddScore(new Score("Marcin", 500));
        scoreManager.AddScore(new Score("Wiktor", 600));
        scoreManager.AddScore(new Score("Slawek", 800));



        var times = scoreManager.GetHighScores().ToArray();

        int doIle;

        if (times.Length <= 7)
        {
            doIle = times.Length;
        }else{
            doIle = 7;
        }
        for(int i = 0; i < doIle; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name.text = times[i].name;
            row.time.text = times[i].time.ToString() ;
        }
    }
}
