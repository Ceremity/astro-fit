using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyPrefab : MonoBehaviour {

    [SerializeField]
    private float destroyAfterDelay;
    void Start()
    {
        Destroy(gameObject, destroyAfterDelay);
    }
}
