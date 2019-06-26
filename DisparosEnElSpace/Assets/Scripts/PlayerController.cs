﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float health = 100;
    public Asteroid asteroid;
  
    void Start()
    {
       
    }

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * speed *Time.deltaTime);
        }
        
    }
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            health -= asteroid.asteroidDamage;
        }
    }

}

