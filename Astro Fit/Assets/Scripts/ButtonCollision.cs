using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCollision : MonoBehaviour {

	public TMPro.TMP_Text text;

	void Start () {
		text = GetComponentInChildren<TMPro.TMP_Text>();
	}

	private void OnTriggerEnter(Collider other) {
		if(other.tag == "Controller") {
			GetComponent<Button>().onClick.Invoke();
		}
	}
}
