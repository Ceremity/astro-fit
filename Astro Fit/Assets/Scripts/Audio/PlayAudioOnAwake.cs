using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayAudioOnAwake : MonoBehaviour {

    [SerializeField]
    private SimpleAudioEvent breakAudio;
    
    void Awake () {
        breakAudio.Play(GetComponent<AudioSource>());
    }
}
