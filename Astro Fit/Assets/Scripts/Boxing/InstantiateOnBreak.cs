using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnBreak : MonoBehaviour {

    [SerializeField]
    private GameObject InstantiatedObject;

    private void Start()
    {
        GetComponent<BreakableObject>().OnBreak += spawnObject;
    }

    private void spawnObject()
    {
        Instantiate(InstantiatedObject, transform.position, transform.rotation);
    }
}
