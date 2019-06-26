using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int asteroidDamage = 25;
    public int speed = 7;
    public int vida = 50;
    public int contador;
    public Bullet bullet;
    public PlayerController player;
    public GAMEUI gameui;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        Destroy(gameObject, 7f);
        if (vida <= 0 && gameObject != null )
        {  
            ObjectDestruction();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet" && gameObject != null)
        {
            
            
            vida -= bullet.damage;
            bullet.DestroyObject();
            

            
        }
        if (other.gameObject.tag == "Ship" && gameObject != null)
        {
            ObjectDestruction();


        }

                
    }

    public void ObjectDestruction()
    {
        Destroy(gameObject);
    }
}
