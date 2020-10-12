using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI score;
    public TextMeshProUGUI scorenum;
    public TextMeshProUGUI hiscore;
    public TextMeshProUGUI hiscorenum;
    public TextMeshProUGUI scoreAdvanceTable;

    private int scorecount;
    private int hiscorecount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scorecount > hiscorecount)
        {
            updateHiScore();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            updateScoreAdvanceTable();
        }

    }

    public void updateScore(string color)
    {

        if (color == "red")
        {
            scorecount += 250;
        }
        else if (color == "green")
        {
            scorecount += 50;
            Debug.Log("hit");
        }
        else if (color == "blue")
        {
            scorecount += 100;
        }
        else if (color == "orange")
        {
            scorecount += 500;
        }

        scorenum.text = string.Format("{0:0000}", scorecount);
    }


    public void updateHiScore()
    {
        hiscorecount = scorecount;
        hiscorenum.text = string.Format("{0:0000}", hiscorecount);


    }
    public void updateScoreAdvanceTable()
    {
        scoreAdvanceTable.text = "";
    }

}
