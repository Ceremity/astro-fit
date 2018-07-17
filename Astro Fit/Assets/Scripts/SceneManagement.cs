using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagement : MonoBehaviour {

    public static SceneManagement Instance;
    private bool isPaused = false;

    [SerializeField]
    private GameObject EndMenu;

    [SerializeField]
    private GameObject LosePrefab;

    void Start() {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        BeatDriver.Instance.OnGameEnd += EndGame;

    }


    public void StartGame() {
        BeatDriver.Instance.ResetGame();
        BeatDriver.Instance.StartSpawning();

    }

    public void EndGame() {
        BeatDriver.Instance.ResetGame();
        BeatDriver.Instance.Pause();
        EndMenu.SetActive(true);
    }

    public void OnLose() {
        Instantiate(LosePrefab);
        EndGame();
    }

    public void Pause() {
        SetTime(.001f);
        BeatDriver.Instance.Pause();
    }

    public void UnPause() {
        SetTime(1f);
        BeatDriver.Instance.UnPause();
    }

    public void TogglePause() {
        if (isPaused)
            UnPause();
        else
            Pause();

        isPaused = !isPaused;
    }

    public void SetTime(float time) {
        Time.timeScale = time;
    }

}
