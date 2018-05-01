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
        // @kimberly: Using FindObject is cool when you're prototyping, but you
        //            want to use something like a...
        //              - Singleton / ServiceLocator
        //              - A reference via the Inspector
        //              - SOMETHING ELSE NOT FIND AAAAAAAH
        hunger = FindObjectOfType<Hunger>();
    }

    // @kimberly: I prefer to keep all of my data members together at the top.
    public int foodLeft = 0;

    public void AddFood()
    {
        foodLeft += 1;

        // @kimberly: When you invoke a delegate, you want to check if it
        //            has a value before doing so.
        //
        //            Unless it should *never* be null. Then don't check.
        foodValue(foodLeft);
    }

    // @kimberly: Kobey got confused by your function name.
    //              "It's called subtract food... but you're adding food?"
    public void SubtactFood()
    {
        if (foodLeft <= 0)
        {
            foodLeft = 0;
        }
        else
        {
            // @kimberly: Don't hard code numbers! Make it variable!
            //            Make it flexible to change! :D
            hunger.currentFood += 100;
        }
        if (hunger.currentFood >= hunger.maxFood)
        {
            foodLeft -= 1;
        }
        foodValue(foodLeft);
        
    }

}
