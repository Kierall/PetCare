using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnValueChange<T>(T newValue);

public class Hunger : MonoBehaviour
{
 
    public float maxFood;
    public float currentFood;
  
    // Rate of food depletion per IRL minute
    public float foodDepletion = 1;

    // Base multiplier applied to food depletion tick
    public float decay = 2;

    [SerializeField]
    private Depletion depletion;

    public OnValueChange<float> updateHunger;

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
