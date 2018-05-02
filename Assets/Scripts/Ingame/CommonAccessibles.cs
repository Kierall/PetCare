using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CommonAccessibles
{
    private static Hunger hunger;
    public static Hunger globalHunger
    {
        get
        {
            return hunger;
        }
        set
        {
            hunger = value;
        }
    }
}
