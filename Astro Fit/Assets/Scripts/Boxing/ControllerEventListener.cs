using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ControllerEventListener : MonoBehaviour {


    private VRTK_ControllerEvents controllerEvents;

    [SerializeField]
    private Spawner spawner;


    private void OnEnable()
    {
        controllerEvents = GetComponent<VRTK_ControllerEvents>();
        if (controllerEvents == null)
        {
            VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
            return;
        }

        //Setup controller event listeners
        controllerEvents.TriggerPressed += DoTriggerPressed;
        //controllerEvents.TriggerReleased += DoTriggerReleased;
        //controllerEvents.TriggerTouchStart += DoTriggerTouchStart;
        //controllerEvents.TriggerTouchEnd += DoTriggerTouchEnd;
        //controllerEvents.TriggerHairlineStart += DoTriggerHairlineStart;
        //controllerEvents.TriggerHairlineEnd += DoTriggerHairlineEnd;
        //controllerEvents.TriggerClicked += DoTriggerClicked;
        //controllerEvents.TriggerUnclicked += DoTriggerUnclicked;
        //controllerEvents.TriggerAxisChanged += DoTriggerAxisChanged;
        //controllerEvents.TriggerSenseAxisChanged += DoTriggerSenseAxisChanged;

        controllerEvents.GripPressed += DoGripPressed;
        //controllerEvents.GripReleased += DoGripReleased;
        //controllerEvents.GripTouchStart += DoGripTouchStart;
        //controllerEvents.GripTouchEnd += DoGripTouchEnd;
        //controllerEvents.GripHairlineStart += DoGripHairlineStart;
        //controllerEvents.GripHairlineEnd += DoGripHairlineEnd;
        //controllerEvents.GripClicked += DoGripClicked;
        //controllerEvents.GripUnclicked += DoGripUnclicked;
        //controllerEvents.GripAxisChanged += DoGripAxisChanged;

        //controllerEvents.TouchpadPressed += DoTouchpadPressed;
        //controllerEvents.TouchpadReleased += DoTouchpadReleased;
        //controllerEvents.TouchpadTouchStart += DoTouchpadTouchStart;
        //controllerEvents.TouchpadTouchEnd += DoTouchpadTouchEnd;
        //controllerEvents.TouchpadAxisChanged += DoTouchpadAxisChanged;
        //controllerEvents.TouchpadTwoAxisChanged += DoTouchpadTwoAxisChanged;
        //controllerEvents.TouchpadSenseAxisChanged += DoTouchpadSenseAxisChanged;

        //controllerEvents.ButtonOnePressed += DoButtonOnePressed;
        //controllerEvents.ButtonOneReleased += DoButtonOneReleased;
        //controllerEvents.ButtonOneTouchStart += DoButtonOneTouchStart;
        //controllerEvents.ButtonOneTouchEnd += DoButtonOneTouchEnd;

        //controllerEvents.ButtonTwoPressed += DoButtonTwoPressed;
        //controllerEvents.ButtonTwoReleased += DoButtonTwoReleased;
        //controllerEvents.ButtonTwoTouchStart += DoButtonTwoTouchStart;
        //controllerEvents.ButtonTwoTouchEnd += DoButtonTwoTouchEnd;

        //controllerEvents.StartMenuPressed += DoStartMenuPressed;
        //controllerEvents.StartMenuReleased += DoStartMenuReleased;

        //controllerEvents.ControllerEnabled += DoControllerEnabled;
        //controllerEvents.ControllerDisabled += DoControllerDisabled;
        //controllerEvents.ControllerIndexChanged += DoControllerIndexChanged;

        //controllerEvents.MiddleFingerSenseAxisChanged += DoMiddleFingerSenseAxisChanged;
        //controllerEvents.RingFingerSenseAxisChanged += DoRingFingerSenseAxisChanged;
        //controllerEvents.PinkyFingerSenseAxisChanged += DoPinkyFingerSenseAxisChanged;
    }

	

	private void OnDisable()
    {
        if (controllerEvents != null)
        {
            controllerEvents.TriggerPressed -= DoTriggerPressed;
            //controllerEvents.TriggerReleased -= DoTriggerReleased;
            //controllerEvents.TriggerTouchStart -= DoTriggerTouchStart;
            //controllerEvents.TriggerTouchEnd -= DoTriggerTouchEnd;
            //controllerEvents.TriggerHairlineStart -= DoTriggerHairlineStart;
            //controllerEvents.TriggerHairlineEnd -= DoTriggerHairlineEnd;
            //controllerEvents.TriggerClicked -= DoTriggerClicked;
            //controllerEvents.TriggerUnclicked -= DoTriggerUnclicked;
            //controllerEvents.TriggerAxisChanged -= DoTriggerAxisChanged;
            //controllerEvents.TriggerSenseAxisChanged -= DoTriggerSenseAxisChanged;

            controllerEvents.GripPressed -= DoGripPressed;
            //controllerEvents.GripReleased -= DoGripReleased;
            //controllerEvents.GripTouchStart -= DoGripTouchStart;
            //controllerEvents.GripTouchEnd -= DoGripTouchEnd;
            //controllerEvents.GripHairlineStart -= DoGripHairlineStart;
            //controllerEvents.GripHairlineEnd -= DoGripHairlineEnd;
            //controllerEvents.GripClicked -= DoGripClicked;
            //controllerEvents.GripUnclicked -= DoGripUnclicked;
            //controllerEvents.GripAxisChanged -= DoGripAxisChanged;

            //controllerEvents.TouchpadPressed -= DoTouchpadPressed;
            //controllerEvents.TouchpadReleased -= DoTouchpadReleased;
            //controllerEvents.TouchpadTouchStart -= DoTouchpadTouchStart;
            //controllerEvents.TouchpadTouchEnd -= DoTouchpadTouchEnd;
            //controllerEvents.TouchpadAxisChanged -= DoTouchpadAxisChanged;
            //controllerEvents.TouchpadTwoAxisChanged -= DoTouchpadTwoAxisChanged;
            //controllerEvents.TouchpadSenseAxisChanged -= DoTouchpadSenseAxisChanged;

            //controllerEvents.ButtonOnePressed -= DoButtonOnePressed;
            //controllerEvents.ButtonOneReleased -= DoButtonOneReleased;
            //controllerEvents.ButtonOneTouchStart -= DoButtonOneTouchStart;
            //controllerEvents.ButtonOneTouchEnd -= DoButtonOneTouchEnd;

            //controllerEvents.ButtonTwoPressed -= DoButtonTwoPressed;
            //controllerEvents.ButtonTwoReleased -= DoButtonTwoReleased;
            //controllerEvents.ButtonTwoTouchStart -= DoButtonTwoTouchStart;
            //controllerEvents.ButtonTwoTouchEnd -= DoButtonTwoTouchEnd;

            //controllerEvents.StartMenuPressed -= DoStartMenuPressed;
            //controllerEvents.StartMenuReleased -= DoStartMenuReleased;

            //controllerEvents.ControllerEnabled -= DoControllerEnabled;
            //controllerEvents.ControllerDisabled -= DoControllerDisabled;
            //controllerEvents.ControllerIndexChanged -= DoControllerIndexChanged;

            //controllerEvents.MiddleFingerSenseAxisChanged -= DoMiddleFingerSenseAxisChanged;
            //controllerEvents.RingFingerSenseAxisChanged -= DoRingFingerSenseAxisChanged;
            //controllerEvents.PinkyFingerSenseAxisChanged -= DoPinkyFingerSenseAxisChanged;
        }
    }

	private void DoGripPressed(object sender, ControllerInteractionEventArgs e) {
		Debug.Log("Grip");
		GameObject controllerCanvas = transform.Find("ControllerCanvas").gameObject;
		if (controllerCanvas != null) {
			controllerCanvas.SetActive(true);
			SceneManagement.Instance.StopTime();
			SceneManagement.Instance.PauseSong();
		}

	}

	private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
    {


        //DebugLogger(VRTK_ControllerReference.GetRealIndex(e.controllerReference), "TRIGGER", "pressed", e);
        spawner.Spawn(UnityEngine.Random.Range(1, 9));
    }

}
