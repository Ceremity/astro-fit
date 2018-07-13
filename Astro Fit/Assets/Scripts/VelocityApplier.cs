using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class VelocityApplier : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField]
    private Vector3 speed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        SetVelocity();
    }

    public void SetVelocity()
    {
        rb.velocity = speed;
    }

    public void Pause()
    {
        rb.velocity = Vector3.zero;
    }

    public void UnPause()
    {
        SetVelocity();
    }
}
