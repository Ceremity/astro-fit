using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SongMenuPopulator : MonoBehaviour {

    private const string path = "Assets\\Resources\\Music\\JSON";

    public static SongMenuPopulator Instance;

    [SerializeField]
    private GameObject gamePanel;

    [SerializeField]
    private GameObject songItemPrefab;

    private string[] filePaths;
    private Song[] songs;

    void Awake () {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        filePaths = Directory.GetFiles(path, "*.json");
        songs = new Song[filePaths.Length];
	}

    private void Start() {
        for(int i = 0; i < filePaths.Length; i++) {
            GameObject item = Instantiate(songItemPrefab, gamePanel.transform);
            songs[i] = BeatDriver.JSONToSong(filePaths[i]);
            item.GetComponent<SongItem>().song = songs[i];
        }
        
    }

    public void HideMenu() {
        gameObject.SetActive(false);
    }

    

    void Update () {
		
	}
}
