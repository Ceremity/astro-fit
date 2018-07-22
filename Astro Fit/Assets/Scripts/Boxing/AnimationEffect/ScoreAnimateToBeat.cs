using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAnimateToBeat : MonoBehaviour {

	private Animation anim;
	// Use this for initialization
	void Start() {
		anim = GetComponent<Animation>();
		ScoreManager.Instance.onScoreChanged += beat;
	}

	// Update is called once per frame
	void Update() {

	}

	void beat() {
		anim.Play();
	}
}
