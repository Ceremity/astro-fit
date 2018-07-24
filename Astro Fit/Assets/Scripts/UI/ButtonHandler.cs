using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

	[SerializeField]
	private GameObject[] deactivateThis;

	private BeatDriver beatDriver;
	private ScoreManager scoreManager;
	private SceneManagement sceneManagement;


	private void Start() {
		beatDriver = BeatDriver.Instance;
		scoreManager = ScoreManager.Instance;
		sceneManagement = SceneManagement.Instance;
	}

	public void UnPauseButtonClick() {
		ControllerReference.Instance.EnablePointers(false);
		sceneManagement.UnPause();
		deactivate();
	}

	public void RestartButtonClick() {
		ControllerReference.Instance.EnablePointers(false);
		scoreManager.ResetScore();
		sceneManagement.UnPause();
		beatDriver.ResetGame();
		beatDriver.StartSpawning();
		scoreManager.ResetScore();
		deactivate();
	}

	private void deactivate() {
		foreach (GameObject obj in deactivateThis) {
			//if (obj != null)
			obj.SetActive(false);
		}
	}

}
