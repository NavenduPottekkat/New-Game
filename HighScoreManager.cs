using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour {

    public Text HS;
    void Awake()
    {
        // Set up the reference.
        HS = GetComponent<Text>();



    }
    void Update() {

        HS.text = "BEST: " + ScoreManager.highscore;
}
}