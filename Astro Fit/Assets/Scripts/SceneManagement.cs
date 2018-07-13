using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagement : MonoBehaviour {

	public static SceneManagement Instance;

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
	public void PauseSong() {
		BeatDriver.Instance.song.Pause();
	}

	public void SetTime(int time) {
		Time.timeScale = time;
	}

	public void UnPauseSong() {
		BeatDriver.Instance.song.UnPause();
	}

}
