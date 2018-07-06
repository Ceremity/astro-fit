using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(menuName = "Audio Events/Simple")]
public class SimpleAudioEvent : AudioEvent {

    [SerializeField]
    private AudioClip[] clips;

    [SerializeField]
    private Vector2 volumeMinMax;

    [SerializeField]
    private Vector2 pitchMinMax;

    public override void Play(AudioSource source)
    {
        if (clips.Length == 0)
            return;

        source.clip = clips[Random.Range(0, clips.Length)];
        source.volume = Random.Range(volumeMinMax.x, volumeMinMax.y);
        source.pitch = Random.Range(pitchMinMax.x, pitchMinMax.y);
        source.Play();
    }
}
