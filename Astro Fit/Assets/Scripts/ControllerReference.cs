using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerReference : MonoBehaviour {

    public static GameObject RightController;
    public static GameObject LeftController;

    void Start () {
        RightController = GameObject.Find("Right Controller");
        LeftController = GameObject.Find("Left Controller");
    }

    void Update () {
		
	}
}
