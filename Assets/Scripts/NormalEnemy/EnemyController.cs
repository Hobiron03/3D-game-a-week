using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float life = 5;
    public GameObject destroyEffect;
    public GameObject mainCamera;

    public AudioClip destroySE;

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
        if (other.gameObject.name == "Bullet(Clone)")
        {
          
            GotShot();
            
            Destroy(other.gameObject);
        }
    }

    void GotShot()
    {
        life -= 1;
        if(life <= 0)
        {
            AudioSource.PlayClipAtPoint(destroySE, mainCamera.transform.position, 0.4f);
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
