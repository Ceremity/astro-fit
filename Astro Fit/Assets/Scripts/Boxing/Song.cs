using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song { 
    public string Title;
    public string Artist;
    public string Album;
    public string Path;
    public float Duration;

    public Song(string Title, string Artist, string Album, string Path, float Duration)
    {
        this.Title = Title;
        this.Artist = Artist;
        this.Album = Album;
        this.Path = Path;
        this.Duration = Duration;
    }	
}
