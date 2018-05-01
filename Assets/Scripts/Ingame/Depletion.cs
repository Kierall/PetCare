using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Depletion : MonoBehaviour
{
    float timer;
    [SerializeField]
    public Text clock;
    [SerializeField]
    public Text dayCounter;

    //public Slider hunger;

    int hours;
    int mintues;
    int seconds;
    public int days;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * 3600.0f;
        MicrowaveTime(timer);
    }
    
    void MicrowaveTime(float time)
    {
       
        seconds = (int)(time % 60);
        mintues = (int)(time / 60 % 60);
        hours = (int)(time / 60 / 60 % 24);
        days = (int)(time / 60 / 60 / 24);

        string microwaveClock = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, mintues, seconds);
        string dayClock = string.Format("Days:  " + "{0:D2}", days);

        clock.text = microwaveClock;
        dayCounter.text = dayClock;
    }
}