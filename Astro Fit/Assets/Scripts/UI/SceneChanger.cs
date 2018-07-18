using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	
	public void ChangeScene(int index) {
		if(SceneManagement.Instance != null)
			SceneManagement.Instance.UnPause();
		SceneManager.LoadScene(index);
	}

	public void QuitGame() {
		Application.Quit();
	}

	
}
