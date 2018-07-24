using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class HeartRateSim : MonoBehaviour {
    [SerializeField]
    private float heartBeatInitial = 70f;
    [SerializeField]
    private float[] heartBeatRange = { 112f, 133f };
    [SerializeField]
    private float updateGap = 1f;
    [SerializeField]
    private float delay = 0f;
    [SerializeField]
    private float minIncrease = 4f;
    [SerializeField]
    private float climbMaxFactor = 1f;
    [SerializeField]
    private float maxDecrease = -5f;
    [SerializeField]
    private float maxIncrease = 3f;
    [SerializeField]
    private float climbFactor = 7f;
    [SerializeField]
    private float finalVariability = 2f;

    public bool isStarted;

    private float currentHeartBeat;
    private float time = 0f;
    private float index;
    private float heartBeatAverage;
    

    private void Start() {
        index = 0f - delay;
        heartBeatAverage = (float)heartBeatRange[0] + heartBeatRange[1] / 2;
    }
    void Update() {
        if (isStarted) {
            time = time + Time.deltaTime;
            if (time > index) {
                index = index + updateGap;
                updateHeartBeat();
            }
        }
    }

    private void updateHeartBeat() {
        System.Random rand = new System.Random();
        if (time < 1f) {
            currentHeartBeat = heartBeatInitial;
        }
        else if (time < 20f) {
            if (currentHeartBeat < heartBeatRange[0])
                currentHeartBeat = currentHeartBeat + rand.Next(0, (int)((heartBeatRange[0] - currentHeartBeat) / climbMaxFactor)) + minIncrease;
            else if (currentHeartBeat <= heartBeatRange[1]) {
                currentHeartBeat = currentHeartBeat + rand.Next((int)maxDecrease, (int)maxIncrease) + ((heartBeatAverage - currentHeartBeat) / climbFactor);
            }
            else {
                currentHeartBeat = currentHeartBeat + rand.Next((int)maxDecrease, 1);
            }
        }
        else {
            currentHeartBeat = currentHeartBeat + rand.Next(-(int)finalVariability, (int)finalVariability);
        }
    }
    public int getHeartBeat() {
        if (!isStarted) return (int)heartBeatInitial;
        return (int)currentHeartBeat;
    }
}