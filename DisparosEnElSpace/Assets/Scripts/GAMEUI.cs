using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAMEUI : MonoBehaviour
{
    public Text points;
    public int kills = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         points.text = "KILLS: "+ kills;
    }
}
