using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class Asteroid : MonoBehaviour
{
    public int asteroidDamage = 25;
    public int speed = 7;
    public int vida = 50;
    public int contador;
    public Bullet bullet;
    public PlayerController player;
    public GAMEUI gameui;
    public GameObject Explosion;
    public AudioClip asteroidSound;
    public AudioSource audioManager;
    
    
    
    void Start()
    {

        gameui = FindObjectOfType<GAMEUI>();
        audioManager = FindObjectOfType<AudioSource>();

    }

    
    void Update()
    {
        
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        Destroy(gameObject, 7f);

        if (vida <= 0 && gameObject != null )
        {
            
            audioManager.PlayOneShot(asteroidSound, 1.5f);
            gameui.kills += 1;
            
            ObjectDestruction();
            Instantiate(Explosion, transform.position, transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet" && gameObject != null)
        {
        
            vida -= bullet.damage;
            
        
        }
        if (other.gameObject.tag == "Ship" && gameObject != null)
        {
            vida -= 50;

        }

                
    }

    public void ObjectDestruction()
    {
        Destroy(gameObject);
    }
}
