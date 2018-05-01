using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodCounter : MonoBehaviour
{
    Hunger hunger;
   
    public delegate void FoodValue(int food);
    public FoodValue foodValue;

    private void Start()
    {
        hunger = FindObjectOfType<Hunger>();
    }

    public int foodLeft = 0;

    public void AddFood()
    {
        foodLeft += 1;
        foodValue(foodLeft);
    }

    public void SubtactFood()
    {
        if (foodLeft <= 0)
        {
            foodLeft = 0;
        }
        else
        {
            hunger.currentFood += 100;
        }
        if (hunger.currentFood >= hunger.maxFood)
        {
            foodLeft -= 1;
        }
        foodValue(foodLeft);
        
    }

}
