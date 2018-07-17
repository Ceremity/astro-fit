using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnBeat : MonoBehaviour {

	private void Start() {
		BeatDriver.Instance.OnUndelayedBeat += changeColor;
	}

	private void changeColor() {
		GetComponent<Renderer>().material.color = Random.ColorHSV();
	}
}
