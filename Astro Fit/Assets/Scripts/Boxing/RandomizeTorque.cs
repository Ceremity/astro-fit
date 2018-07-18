using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RandomizeTorque : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField]
    private float torqueMin;

    [SerializeField]
    private float torqueMax;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
		setTorque();

	}

	public void setTorque() {
		rb.AddTorque(transform.up * Random.Range(torqueMin, torqueMax) * Time.deltaTime);
		rb.AddTorque(transform.forward * Random.Range(torqueMin, torqueMax) * Time.deltaTime);
	}
}
