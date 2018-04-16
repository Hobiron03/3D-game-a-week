using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyllinderEnemy : MonoBehaviour {

    public bool isRotate = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isRotate)
        {
            transform.Rotate(new Vector3(0, 0.3f, 0));
        }
        
	}
}
