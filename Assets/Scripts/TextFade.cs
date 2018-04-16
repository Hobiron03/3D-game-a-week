using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class TextFade : MonoBehaviour {

    public bool gameClear = false;
    public bool gameOver = false;

    float fadeSpeed = 0.05f;
    float red, green, blue, alpha;
    TextMeshProUGUI fadeImage;

    
    // Use this for initialization
    void Start ()
    {
        fadeImage = GetComponent<TextMeshProUGUI>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alpha = fadeImage.color.a;

        
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(gameClear)
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
            gameClear = false;
            
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alpha);
    }
}
