using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HungerUI : MonoBehaviour
{
    Hunger hunger;
    public Slider hungerBar;
    // Use this for initialization
    void Start()
    {
        hungerBar = GetComponent<Slider>();
        hunger = FindObjectOfType<Hunger>();
        hunger.updateHunger += updateSlider;
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void updateSlider(float hunger)
    {
        hungerBar.value = hunger;
    }
}
