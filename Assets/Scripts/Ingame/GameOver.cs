using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        CommonAccessibles.globalHunger.updateHunger += gameOver;
    }

    void gameOver(float food)
    {
        if(food <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
