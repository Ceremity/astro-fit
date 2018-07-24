using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// It's a singleton
/// </summary>
public class BeatDriver : MonoBehaviour {

	public static BeatDriver Instance;

	public List<Beat> beatz;

	[SerializeField]
	private AudioSource song;

	[SerializeField]
	private Spawner spawner;

	[SerializeField]
	private float distanceDelay;

	[SerializeField]
	private float startDelay;

	private float currentTime;

	private int delayedIndex;
	private int undelayedIndex;

	private bool isRunning = false;

    private HeartRateSim heartSim;

	public event Action OnDelayedBeat = delegate { };
	public event Action OnUndelayedBeat = delegate { };
    public event Action OnGameEnd = delegate { };


    private void Awake() {
		if (Instance == null)
			Instance = this;
		else
			Destroy(this);
	}
	void Start() {
        heartSim =  ScoreManager.Instance.GetComponent<HeartRateSim>();

        //beatz = new List<Beat>();
        //for (int i = 0; i < 172; i++) {
        //	//int randomLoc = Random.Range(1, 9);
        //	beatz.Add(new Beat(i, 5));
        //	if (i % 4 == 1) {
        //		beatz.Add(new Beat(i + .5f, 5));
        //	}
        //}
        //readSong(JSONToSong("D:\\Git\\astro-fit\\Astro Fit\\Assets\\Resources\\Music\\JSON\\GodFury.json")); 
    }

	void Update() {
		if (!isRunning) 
			return;
        if (undelayedIndex >= beatz.Count) {
            Debug.Log("End");
            OnGameEnd();
            heartSim.isStarted = false;
            isRunning = false;
            return;
        }
		currentTime += Time.deltaTime;

		float nextSpawnTime = beatz[delayedIndex].timestamp - distanceDelay;
        if (currentTime >= nextSpawnTime) {
            if (delayedIndex < beatz.Count - 1) {
                SpawnBeat(beatz[delayedIndex]);
                OnDelayedBeat();
                delayedIndex++;
            }
        }
		if(currentTime >= beatz[undelayedIndex].timestamp) {
			OnUndelayedBeat();
			undelayedIndex++;
		}
	}

	public void ResetGame() {
        foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Breakable"))
            Destroy(obj);

		currentTime = -distanceDelay - startDelay;
		delayedIndex = 0;
		undelayedIndex = 0;
		song.time = 0;
		song.Pause();
		isRunning = false;
	}

	public void StartSpawning() {
        ResetGame();
		isRunning = true;
		StartCoroutine(StartSong());
	}

	private void SpawnBeat(Beat beat) {
		spawner.Spawn(beat);
	}

	IEnumerator StartSong() {
		Debug.Log("waiting to start song");
		yield return new WaitForSeconds(startDelay + distanceDelay);
		Debug.Log("started song");
        heartSim.isStarted = true;
		song.Play();
	}

    public void Pause()
    {
        song.Pause();
        isRunning = false;
    }

    public void UnPause()
    {
		if(song != null)
			song.UnPause();
        isRunning = true;
    }

    public static Song JSONToSong(string path)
    {
        string jsonString = File.ReadAllText(path);
        Song song = JsonUtility.FromJson<Song>(jsonString);
        song.ImageSprite = Resources.Load<Sprite>(song.ImagePath) as Sprite;
        return song;
    }

    public void readSong(Song song)
    {
        this.song.clip = Resources.Load<AudioClip>(song.SongPath) as AudioClip;
        beatz = new List<Beat>();
        for (int i = 0; i < song.times.Length; i++)
        {
            beatz.Add(new Beat(song.times[i],song.position[i]));
        }
    }

}
