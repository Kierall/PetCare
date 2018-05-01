﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : MonoBehaviour
{
    [SerializeField]
     public float maxFood;
    [SerializeField]
    public float currentFood;

    // @kimberly: You're creating a few delegates... that all kinda do the same thing.
    //            Maybe you could create a *generic* "OnValueChanged<T>"?
    public delegate void UpdateHunger(float hunger);
  
    // Rate of food depletion per IRL minute
    [SerializeField]
    public float foodDepletion = 1;

    // Base multiplier applied to food depletion tick
    [SerializeField]
    public float decay = 2;

    [SerializeField]
    private Depletion depletion;

    public UpdateHunger updateHunger;

    float timer;
    // Use this for initialization
    void Start()
    {
        currentFood = maxFood;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * 60;
        FoodDepletion();
        updateHunger(currentFood);
    }
    void FoodDepletion()
    {
        if (currentFood >= 0)
        {
            currentFood -= (foodDepletion / 60) * Time.deltaTime * HungerDepletionMultiplier(depletion.days);
        }
        if(currentFood >= 100)
        {
            currentFood = maxFood;
        }
        if(foodDepletion <= 0)
        {
            foodDepletion /= 60;
        }
    }

    float HungerDepletionMultiplier(int dayCount)
    {
        return (float)Mathf.Clamp(Mathf.Pow(decay, dayCount), 1, Mathf.Infinity);
    }
}
