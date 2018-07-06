using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour {

    [SerializeField]
    private float deathDelay = 0;

    public event Action OnBreak = delegate { };


    public void DoBreak()
    {
        OnBreak();
        Destroy(gameObject, deathDelay);
    }
}
