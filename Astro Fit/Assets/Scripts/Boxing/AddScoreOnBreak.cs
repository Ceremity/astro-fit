using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class AddScoreOnBreak : MonoBehaviour {

    [SerializeField]
    private int scoreAmount;

    private void Start()
    {
        GetComponent<BreakableObject>().OnBreak += addScore;
    }

    private void addScore()
    {
        ScoreManager.Instance.AddScore(scoreAmount);
    }
}
