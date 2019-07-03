using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid;
    void Start()
    {
        InvokeRepeating("CreateObject", 3f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void CreateObject()
    {
        Vector3 posicion = new Vector3(Random.Range(-17f, 17f), 0, 17.107f);
        Instantiate(asteroid, posicion, Quaternion.identity);
    }
}
