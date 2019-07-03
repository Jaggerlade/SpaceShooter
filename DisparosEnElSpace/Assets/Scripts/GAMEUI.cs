using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (kills >= 30)
        {
            SceneManager.LoadScene("YouWin");
        }
         points.text = "KILLS: "+ kills;
    }
    public IEnumerator GameLost()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("YouLost");
    }
}
