using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongItem : MonoBehaviour {

    public Song song;


    private void Start() {
        GetComponent<Image>().sprite = song.ImageSprite;
        GetComponent<Button>().onClick.AddListener(loadSong);
    }

    private void loadSong() {
        BeatDriver.Instance.readSong(song);
        SongMenuPopulator.Instance.HideMenu();
    }
}
