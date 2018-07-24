using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunrayOnBeat : MonoBehaviour {

    [SerializeField]
    private Material mat;

    [SerializeField]
    private Color color1;

    [SerializeField]
    private Color color2;

    private void Start() {
        BeatDriver.Instance.OnUndelayedBeat += changeColor;
    }

    private void changeColor() {
        float r = Random.Range(color1.r, color2.r);
        float g = Random.Range(color1.g, color2.g);
        float b = Random.Range(color1.b, color2.b);
        float a = Random.Range(color1.a, color2.a);

        Color newColor = new Color(r, g, b, a);
        mat.SetColor("_TintColor", newColor);
    }
}
