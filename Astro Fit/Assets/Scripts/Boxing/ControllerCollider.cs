using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ControllerCollider : MonoBehaviour {

    [SerializeField]
    private GameObject controllerObject;

    void OnTriggerEnter(Collider collider)
    {
        VRTK_ControllerHaptics.TriggerHapticPulse(VRTK_ControllerReference.GetControllerReference(controllerObject), 1);
        if (collider.tag.Equals("Breakable"))
        {
            collider.GetComponent<BreakableObject>().DoBreak();
        }
    }
}
