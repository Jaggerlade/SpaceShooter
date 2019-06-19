using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{

    public GameObject Bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right shift"))
        {
            
            Invoke("Disparar", 0.1f);
        }
    }

    void Disparar()
    {
        Instantiate(Bullet, transform.position, transform.localRotation);
        
    }
    
}
