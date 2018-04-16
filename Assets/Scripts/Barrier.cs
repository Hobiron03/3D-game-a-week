using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour {

    public GameObject gameController;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "Bullet")
        {
            
            Destroy(other.gameObject);
        }
    }

    public void DestroyBarrier()
    {
        Destroy(gameObject);
    }
}
