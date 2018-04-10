using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour {

    public GameObject player;
    public float lookPlayerSpeed = 3.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    private void LateUpdate()
    {
        LookPlayer();	
    }

    void LookPlayer()
    {

        Vector3 targetDir = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z) - transform.position;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, lookPlayerSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
