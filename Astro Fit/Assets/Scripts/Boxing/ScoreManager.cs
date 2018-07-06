using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager Instance;

    private static int score { get;  set; }
    public event Action onScoreChanged = delegate { };

    [SerializeField]
    private TMPro.TextMeshProUGUI scoreText;


    private void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        onScoreChanged += updateText;
    }

    private void Awake()
    {
        score = 0;
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
        onScoreChanged();
    }
}
