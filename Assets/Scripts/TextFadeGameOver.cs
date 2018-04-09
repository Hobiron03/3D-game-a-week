using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;


public class TextFadeGameOver : MonoBehaviour {

    public bool isGameOver = false;

    float fadeSpeed = 0.05f;
    float red, green, blue, alpha;
    TextMeshProUGUI fadeImage;

    AudioSource audio;
    // Use this for initialization
    void Start()
    {
        fadeImage = GetComponent<TextMeshProUGUI>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alpha = fadeImage.color.a;


    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            StartFadeOut();
        }
    }

    void StartFadeOut()
    {

        alpha += fadeSpeed;
        SetAlpha();

        if (alpha >= 255)
        {
            isGameOver = false;
            audio.Play();
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alpha);
    }
}
