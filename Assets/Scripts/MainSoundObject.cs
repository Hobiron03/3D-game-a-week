using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSoundObject : MonoBehaviour {
    public bool DontDestroyEnable = true;
	// Use this for initialization
	void Start () {
       

		if(DontDestroyEnable)
        {
            DontDestroyOnLoad(this);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(SceneManager.GetActiveScene().name == "Clear")
        {
            Destroy(gameObject);
        }
    }
}
