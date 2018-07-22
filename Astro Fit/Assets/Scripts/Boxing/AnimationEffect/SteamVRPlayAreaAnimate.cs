using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamVRPlayAreaAnimate : MonoBehaviour {

	private SteamVR_PlayArea playArea;
	public float speed;

	// Use this for initialization
	void Start () {
		playArea = GetComponent<SteamVR_PlayArea>();
		BeatDriver.Instance.OnUndelayedBeat += beat;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if(playArea.color.a > .5) {
			playArea.color.a-= speed;
			playArea.BuildMesh();
		}
	}

	void beat() {
		playArea.color = new Color(playArea.color.r, playArea.color.g, playArea.color.b, 1);
		playArea.BuildMesh();

	}
}
