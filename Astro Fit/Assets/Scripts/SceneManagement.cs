<<<<<<< HEAD
﻿using System;
using System.Collections;
=======
﻿using System.Collections;
>>>>>>> 53b86bbc2535a691b471d47268e925e7e606726f
using System.Collections.Generic;
using UnityEngine;

public class SceneManagement : MonoBehaviour {

	public static SceneManagement Instance;
<<<<<<< HEAD
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
=======

	// Use this for initialization
	void Start () {
>>>>>>> 53b86bbc2535a691b471d47268e925e7e606726f
		if (Instance == null)
			Instance = this;
		else
			Destroy(this);
	}
<<<<<<< HEAD

    public void StopTime() {
		Time.timeScale = .001f;
	}
=======
	public void StopTime() {
		Time.timeScale = .001f;
	}
	public void PauseSong() {
		BeatDriver.Instance.song.Pause();
	}
>>>>>>> 53b86bbc2535a691b471d47268e925e7e606726f

	public void SetTime(int time) {
		Time.timeScale = time;
	}

<<<<<<< HEAD
=======
	public void UnPauseSong() {
		BeatDriver.Instance.song.UnPause();
	}

>>>>>>> 53b86bbc2535a691b471d47268e925e7e606726f
}
