using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float starthealth = 100;
    private float health;
    public GAMEUI gameUi;
    

    public Asteroid asteroid;
    public GameObject PlayerExplosion;
    public AudioClip PlayerSoundExplosion;
    public AudioSource audioManager;
    public Image healthBar;
  
    void Start()
    {
        health = starthealth;
        audioManager = FindObjectOfType<AudioSource>();
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
        var pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -17f, 17f);
        pos.z = Mathf.Clamp(transform.position.z, -3.2f, 14f);
        transform.position = pos;

        if (health <= 0)
        {
            
            audioManager.PlayOneShot(PlayerSoundExplosion, 1.5f);
            Destroy(gameObject);
            Instantiate(PlayerExplosion, transform.position, transform.rotation);

            gameUi.StartCoroutine(gameUi.GameLost());
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {

            health -= asteroid.asteroidDamage;
            healthBar.fillAmount = health / starthealth;
        }
    }

}

