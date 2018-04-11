﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseEnemyshot : MonoBehaviour {

    public GameObject enemyBullet;

    public float time = 0;
    public float timeInterval = 0.9f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;

        if (timeInterval < time)
        {
            // Quaternion rotate = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, 0.0f);
            var bullet = Instantiate(enemyBullet, transform.position, Quaternion.identity) as GameObject;
            bullet.transform.rotation = transform.rotation;
            time = 0f;
        }
    }
}
