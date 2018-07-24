using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager Instance;

    public static int score { get;  set; }

    public event Action onScoreChanged = delegate { };

    [SerializeField]
    private TMPro.TMP_Text scoreText;

	private void Awake() {
		if (Instance == null)
			Instance = this;
		else
			Destroy(this);

		ResetScore();
	}

	private void Start()
    {
        onScoreChanged += updateText;
    }

 

	public void ResetScore() {
		score = 0;
		updateText();
	}

    private void updateText()
    {
        scoreText.text = score.ToString();
    }

    /// <summary>
    /// This adds score to the scoremanager
    /// </summary>
    /// <param name="amt">The amount of score you want to add</param>
    public void AddScore(int amt)
    {
        score += amt;
        if(score > PlayerPrefs.GetInt("HighScore", 0)) {
            PlayerPrefs.SetInt("HighScore", score);
        }
        onScoreChanged();
    }
}
