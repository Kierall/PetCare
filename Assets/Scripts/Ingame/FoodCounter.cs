using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodCounter : MonoBehaviour
{
    [SerializeField]
    private int hungerValChange;

    public int animalFoodLeft = 0;

    public OnValueChange<int> foodValue;


    public void AddAnimalFood()
    {
        animalFoodLeft += 1;
        foodValue(animalFoodLeft);
    }

    public void SubtactAnimalFood()
    {
        if (animalFoodLeft <= 0)
        {
            animalFoodLeft = 0;
        }
        else
        {
            CommonAccessibles.globalHunger.currentFood += hungerValChange;
        }
        if (CommonAccessibles.globalHunger.currentFood >= CommonAccessibles.globalHunger.maxFood)
        {
            animalFoodLeft -= 1;
        }
        foodValue(animalFoodLeft);

    }
}
