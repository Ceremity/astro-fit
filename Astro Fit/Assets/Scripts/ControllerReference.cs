using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerReference : MonoBehaviour {

	public static ControllerReference Instance;

    public GameObject RightController;
    public GameObject LeftController;
	public GameObject RightPointer;
	public GameObject LeftPointer;

	public GameObject rightGlove;
	public GameObject leftGlove;

	public GameObject rightControllerObject;
	public GameObject leftControllerObject;

	private void Awake() {
		if (Instance == null)
			Instance = this;
		else
			Destroy(this);
	}

	public void EnablePointers(bool isPointerOn) {
			rightGlove.SetActive(!isPointerOn);
			leftGlove.SetActive(!isPointerOn);

			rightControllerObject.SetActive(isPointerOn);
			leftControllerObject.SetActive(isPointerOn);

			RightPointer.SetActive(isPointerOn);
			LeftPointer.SetActive(isPointerOn);
		
	}
}
