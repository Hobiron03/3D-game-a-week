using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 500;
    public GameObject fireSpot;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;
        Invoke("Destroy", 2.0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    void Destroy()
    {
        Destroy(gameObject);
    }
}
