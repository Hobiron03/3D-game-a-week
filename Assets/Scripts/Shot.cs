using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    public GameObject bullet;

    float timeInterval = 0.15f;
    float time = 0f;
	// Use this for initialization
	void Start () {
		
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
                time = 0f;
            }
            
           
        }
    }
}
