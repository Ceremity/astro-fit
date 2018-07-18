using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class MenuSoundWaitSceneLoad : MonoBehaviour {

	public UnityEngine.Events.UnityEvent RunAfterSound;

	private AudioSource audio;

	private void Start() {
		audio = GetComponent<AudioSource>();
	}


	public void PlaySound() {
		if(audio != null && audio.clip != null)
			StartCoroutine(DelayedLoad());
	}

	IEnumerator DelayedLoad() {
		//Play the clip once
		audio.Play();

		//Wait until clip finish playing
		yield return new WaitForSeconds(audio.clip.length);

		//Load scene here
		RunAfterSound.Invoke();

	}
}
