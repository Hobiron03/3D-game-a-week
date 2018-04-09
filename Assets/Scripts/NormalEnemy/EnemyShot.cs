using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

    public GameObject enemyBullet;
    public GameObject player;
    

    float timeInterval = 1.0f;
    float time = 0f;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

            if (timeInterval < time)
            {
                Instantiate(enemyBullet, transform.position, Quaternion.LookRotation(player.transform.position - transform.position));
                time = 0f;
            }
     
    }

}
