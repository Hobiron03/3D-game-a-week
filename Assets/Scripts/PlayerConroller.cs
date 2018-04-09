using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour {

    public float speed = 20f;
    public int hp = 5;
    public GameObject DestroyEffect;
    AudioSource audio;
    public AudioClip destroySE;
    public GameObject mainCamera;

    float moveX = 0f;
    float moveZ = 0f;
    Rigidbody rb;
    public GameObject gameController;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * speed;
        moveZ = Input.GetAxis("Vertical") * speed;
       // Vector3 direction = new Vector3(moveX, 0, moveZ);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(moveX, 0, moveZ);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EnemyBullet")
        {
            hp -= 1;
            Destroy(other.gameObject);
            //GameDirector.SetHpGage(hp);
            gameController.GetComponent<GameDirector>().SetHpGage(hp);
            if(hp <= 0)
            {
                AudioSource.PlayClipAtPoint(destroySE, mainCamera.transform.position, 0.4f);
                Instantiate(DestroyEffect, transform.position, Quaternion.identity);
                gameController.GetComponent<GameDirector>().GameOver();
                Destroy(gameObject);
            }
            audio.Play();
        }
    }
}
