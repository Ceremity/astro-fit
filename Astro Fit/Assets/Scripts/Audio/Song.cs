using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Song {
    public string Title;
    public string Artist;
    public string Album;
    public float length;
    public float[] times;
    public int[] position;
    public string SongPath;
    public string ImagePath;
    public Sprite ImageSprite;
}
