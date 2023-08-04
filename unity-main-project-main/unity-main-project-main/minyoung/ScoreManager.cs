using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int totalScore;

    public int score;

    public Text scoreboard;

    public OrderManager ordermanager;

    public Text scoreNote;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void servedFoodScore(bool bo)
    {
        score = 0;
        switch (ordermanager.difficulty)
        {
            case 1:
                {
                    if (bo)
                        score = 50;
                    else
                        score = -10;
                    break;
                }
            case 2:
                {
                    if (bo)
                        score = 80;
                    else
                        score = -30;
                    break;
                }
            case 3:
                {
                    if (bo)
                        score = 100;
                    else
                        score = -50;
                    break;
                }
        }

        
        totalScore += score;
        scoreboard.text = "Score: " + (int)totalScore;
        if(score > 0)
        {
            scoreNote.text = "+" + (int)score;
        }
        else
        {
            scoreNote.text = ""+ (int)score;
        }
            
        ordermanager.recipe();
    }
}
