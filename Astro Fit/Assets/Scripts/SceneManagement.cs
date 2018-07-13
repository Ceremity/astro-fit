using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagement : MonoBehaviour {

	public static SceneManagement Instance;
    private bool isPaused = false;
    
    public void TogglePause()
    {
        if (isPaused)
            UnPause();
        else
            Pause();

        isPaused = !isPaused;
    }

    public void Pause()
    {
        StopTime();
        BeatDriver.Instance.Pause();
    }

    public void UnPause()
    {
        SetTime(1);
        BeatDriver.Instance.UnPause();
    }

    // Use this for initialization
    void Start () {
		if (Instance == null)
			Instance = this;
		else
			Destroy(this);
	}

    public void StopTime() {
		Time.timeScale = .001f;
	}

	public void SetTime(int time) {
		Time.timeScale = time;
	}

}
