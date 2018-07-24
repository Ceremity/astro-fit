using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAnimateToBeat : MonoBehaviour {

	private Animator anim;

    [SerializeField]
    private TMPro.TMP_Text heartRateText;

    private HeartRateSim heartSim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
        heartSim = ScoreManager.Instance.GetComponent<HeartRateSim>();
		BeatDriver.Instance.OnUndelayedBeat += beat;
	}

    private void Update() {
        heartRateText.text = heartSim.getHeartBeat().ToString();
    }


    void beat() {
		anim.Play("HeartBigBeat");
	}
}
