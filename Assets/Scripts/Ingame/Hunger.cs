using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : MonoBehaviour
{
    [SerializeField]
     float maxFood;
    [SerializeField]
     float currentFood;


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
        currentFood -= (foodDepletion / 60) * Time.deltaTime * HungerDepletionMultiplier(depletion.days);
    }

    float HungerDepletionMultiplier(int dayCount)
    {
        return (float)Mathf.Clamp(Mathf.Pow(decay, dayCount), 1, Mathf.Infinity);
    }
}
