using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HungerUI : MonoBehaviour
{
    public Slider hungerBar;
    // Use this for initialization
    void Start()
    {
        hungerBar = GetComponent<Slider>();
        CommonAccessibles.globalHunger.updateHunger += updateSlider;
    }
    void updateSlider(float hunger)
    {
        hungerBar.value = hunger;
    }
}
