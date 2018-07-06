using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat {

    public float timestamp { get; set; } // in seconds
    public int position { get; set; }

    public Beat(float timestamp, int position) {

        this.timestamp = timestamp;
        this.position = position;
    }
    
}
