using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    [SerializeField]
    private float size = 1f;
    [SerializeField]
    private GameObject breakablePrefab;
    [SerializeField]
    private float xDistance = 0.13f;
    [SerializeField]
    private float yDistanceHigh = 1.45f;
    [SerializeField]
    private float yDistanceLow = 0.97f;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            for (int i = 0; i <= 3; i++) {
                Spawn(i);
            }
        }

        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //    Spawn(2);
        //if (Input.GetKeyDown(KeyCode.Alpha3))
        //    Spawn(3);
        //if (Input.GetKeyDown(KeyCode.Alpha4))
        //    Spawn(4);
        //if (Input.GetKeyDown(KeyCode.Alpha5))
        //    Spawn(5);
        //if (Input.GetKeyDown(KeyCode.Alpha6))
        //    Spawn(6);
        //if (Input.GetKeyDown(KeyCode.Alpha7))
        //    Spawn(7);
        //if (Input.GetKeyDown(KeyCode.Alpha8))
        //    Spawn(8);
        //if (Input.GetKeyDown(KeyCode.Alpha9))
        //    Spawn(9);
    }

    public void Spawn(int key)
    {
        Vector3 spawnPosition = new Vector3();
        switch(key) {
            case 0: spawnPosition = new Vector3(-xDistance, yDistanceHigh, 0); break;
            case 1: spawnPosition = new Vector3(xDistance,yDistanceHigh, 0); break;
            case 2: spawnPosition = new Vector3(-xDistance, yDistanceLow, 0); break;
            case 3: spawnPosition = new Vector3(xDistance, yDistanceLow, 0); break;
        }
        //int row = (key - 1) % 3;
        //int col = (key - 1) / 3;
        //float x = row * size - size;
        //float y = col * size + size;
        Instantiate(breakablePrefab, transform.position + spawnPosition, Quaternion.identity);

    }

    public void Spawn(Beat beat) {
        Spawn(beat.position);
    }
}
