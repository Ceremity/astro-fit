﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	
	public void ChangeScene(int index) {
		Debug.Log("changing scene");
		SceneManager.LoadScene(index);
	}

	public void QuitGame() {
		Application.Quit();
	}

	
}