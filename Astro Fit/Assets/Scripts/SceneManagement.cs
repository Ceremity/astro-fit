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

	private void Awake() {
		if (Instance == null)
			Instance = this;
		else
			Destroy(this);
	}

	void Start() {
		BeatDriver.Instance.OnGameEnd += EndGame;
    }


	public void StartGame() {
		BeatDriver.Instance.ResetGame();
		BeatDriver.Instance.StartSpawning();

	}

	public void EndGame() {
        BeatDriver.Instance.ResetGame();
		//BeatDriver.Instance.Pause();
		ControllerReference.Instance.EnablePointers(true);
		EndMenu.SetActive(true);
    }

    public void OnLose() {
        Instantiate(LosePrefab);
        EndGame();
    }

    public void Pause() {
        SetTime(.001f);
		ControllerReference.Instance.EnablePointers(true);
		BeatDriver.Instance.Pause();
		isPaused = true;
    }

    public void UnPause() {
		Debug.Log("unpause");
		SetTime(1f);
		ControllerReference.Instance.EnablePointers(false);
		BeatDriver.Instance.UnPause();
		isPaused = false;

	}

	public void TogglePause() {
        if (isPaused)
            UnPause();
        else
            Pause();
    }

    public void SetTime(float time) {
        if(time < .5) 
			foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Breakable")) {
				Rigidbody rb = obj.GetComponent<Rigidbody>();
				if (rb != null)
					rb.isKinematic = true;
			} 
		else {
			foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Breakable")) {
				Rigidbody rb = obj.GetComponent<Rigidbody>();
				VelocityApplier ap = obj.GetComponent<VelocityApplier>();
				RandomizeTorque rt = obj.GetComponent<RandomizeTorque>();
				if (rb != null && ap != null && rt != null) {
					rb.isKinematic = false;
					ap.SetVelocity();
					rt.setTorque();
				}
			}
		}
	}

}
