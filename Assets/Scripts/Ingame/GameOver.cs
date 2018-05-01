using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Hunger hunger;
    // Use this for initialization
    void Start()
    {
        hunger = FindObjectOfType<Hunger>();
        hunger.updateHunger += gameOver;
    }

    // @kimberly: Remove empty Update() calls if you aren't using them!
    //            see: https://blogs.unity3d.com/2015/12/23/1k-update-calls/
    
    // Update is called once per frame
    void Update()
    {

    }

    void gameOver(float food)
    {
        if(food <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
