using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{

    public GameObject Bullet;
    public AudioClip shootSound;
    public AudioSource audioManager;
    void Start()
    {
        
        audioManager = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right shift"))
        {

            Disparar();
        }
    }

    void Disparar()
    {
        audioManager.PlayOneShot(shootSound, 0.45f);
        Instantiate(Bullet, transform.position, transform.localRotation);
        
    }
    
}
