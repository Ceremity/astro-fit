using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAnimateToBeat : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		BeatDriver.Instance.OnUndelayedBeat += beat;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void beat() {
		anim.Play("HeartBigBeat");
	}
}
