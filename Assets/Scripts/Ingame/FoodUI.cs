using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodUI : MonoBehaviour
{
    public Text foodCounter;
    FoodCounter food;
    // Use this for initialization
    void Start()
    {
        food = FindObjectOfType<FoodCounter>();
        food.foodValue += UpdateFoodUI;
    }
    void UpdateFoodUI(int food)
    {
       
        foodCounter.text = "Food: " + food;
    }
}
