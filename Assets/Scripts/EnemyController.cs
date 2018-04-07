using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float life = 5;

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
            Debug.Log("あたったよ");
            GotShot();
            Destroy(other.gameObject);
        }
    }

    void GotShot()
    {
        life -= 1;
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
