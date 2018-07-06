using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class VelocityApplier : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField]
    private Vector3 speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity = speed;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
