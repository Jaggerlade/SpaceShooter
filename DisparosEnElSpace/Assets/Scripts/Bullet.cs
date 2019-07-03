using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 25;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward);

    }
    public void DestroyObject()
    {
        if (gameObject != null)
        {
            DestroyImmediate(gameObject, true);

        }
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Asteroid" && gameObject != null)
        {
            Destroy(gameObject);

        }

    }
}
