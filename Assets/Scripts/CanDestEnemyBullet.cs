using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDestEnemyBullet : MonoBehaviour {

    public float speed = 15; 

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;
        Invoke("Destroy", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
