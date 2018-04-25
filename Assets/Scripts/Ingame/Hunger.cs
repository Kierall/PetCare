using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{
    [SerializeField]
    public Slider hungerBar;
    [SerializeField]
    public float maxFood;
    [SerializeField]
    public float currentFood;

    // Rate of food depletion per IRL minute
    [SerializeField]
    public float foodDepletion = 1;

    // Base multiplier applied to food depletion tick
    [SerializeField]
    public float decay = 2;

    [SerializeField]
    private Depletion depletion;

    float timer;
    // Use this for initialization
    void Start()
    {
        hungerBar.maxValue = maxFood;
        currentFood = maxFood;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * 60;
        FoodDepletion();
        /*Food = 100
         * day 0 - food decresess the normal rate (100 - 1?)
         * 
         * 
         */
        hungerBar.value = currentFood;
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
