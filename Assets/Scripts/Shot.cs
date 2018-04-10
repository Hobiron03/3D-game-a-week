using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    public GameObject bullet;

    AudioSource audio;
    public AudioClip audioClip;

    float timeInterval = 0.1f;
    float time = 0f;
	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();	
	}

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            if (timeInterval < time)
            {
                Instantiate(bullet, transform.position, this.gameObject.transform.rotation);
                audio.PlayOneShot(audioClip);
                time = 0f;
            }
            
           
        }
    }
}
