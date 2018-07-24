using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameMenuUpdate : MonoBehaviour {

    [SerializeField]
    private TMPro.TMP_Text scoreText;

    [SerializeField]
    private TMPro.TMP_Text highScoreText;

    [SerializeField]
    private TMPro.TMP_Text avgHeartRate;

    // Use this for initialization
    void Start () {
        //BeatDriver.Instance.OnGameEnd += updateText;
        updateText();

    }
	
	void updateText () {
        scoreText.text = "Score: " + ScoreManager.score;
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString() ;
        avgHeartRate.text = "Average Heart Rate\n" + (int)Random.Range(110, 130);

    }
}
