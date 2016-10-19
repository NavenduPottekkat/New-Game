using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        

    public static int highscore;
    public Text text;                   


    void Awake()
    {
       
        text = GetComponent<Text>();

       
        score = 0;
    }


    void Update()
    {
        
        text.text = "SCORE: " + score;

        if (score > highscore)
            highscore = score;

        PlayerPrefs.SetInt("highscore", highscore);
        PlayerPrefs.Save();
    }
}