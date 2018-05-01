using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    // @kimberly: Do you need to store this as a data member?
    //            Seems like you only need it in Start()
    Resolution[] resolution;
   
    public Dropdown res;
    public Slider qSlider;
    public Text qText;

    private void Start()
    {
        resolution = Screen.resolutions;

        res.onValueChanged.AddListener(delegate { Screen.SetResolution(resolution[res.value].width, resolution[res.value].height, true); });

        for (int i = 0; i < resolution.Length; i++)
        {
            // @kimberly: You may want to use the ctor for Dropdown.OptionData()
            //            that accepts a string to initialize with.
            // https://docs.unity3d.com/ScriptReference/UI.Dropdown.OptionData-ctor.html
            Dropdown.OptionData addedData = new Dropdown.OptionData();
            addedData.text = ResToString(resolution[i]);
            res.options.Add(addedData);
        }

        qSlider.maxValue = 6;
        qSlider.minValue = 1;
        QualitySettings.SetQualityLevel(0);
    }
   
    // @kimberly: As a general rule of thumb, I generally prefer to always
    //            specify whether its public/private/protected instead of
    //            omitting it and relying on the default (private).
    string ResToString(Resolution RTS)
    {
        return RTS.width + " x " + RTS.height;
    }


   

    public void graphics()
    {
        /*
        @kimberly: Is there any reason why you're creating new variables?
         */
        Slider graphics = qSlider;
        Text graphicsText = qText;

        /*
        @kimberly: You could probably condense this down into a switch
                   as a start!
         */
        if (graphics.value == 1)
        {
            QualitySettings.SetQualityLevel(0);
            graphicsText.text = "Quality: Lowest";
            Debug.Log(QualitySettings.GetQualityLevel());
        }
        if (graphics.value == 2)
        {
            QualitySettings.SetQualityLevel(1);
            graphicsText.text = "Quality: Low";
            Debug.Log(QualitySettings.GetQualityLevel());
        }
        if (graphics.value == 3)
        {
            QualitySettings.SetQualityLevel(2);
            graphicsText.text = "Quality: Medium";
            Debug.Log(QualitySettings.GetQualityLevel());
        }
        if (graphics.value == 4)
        {
            QualitySettings.SetQualityLevel(3);
            graphicsText.text = "Quality: High";
            Debug.Log(QualitySettings.GetQualityLevel());
        }
        if (graphics.value == 5)
        {
            QualitySettings.SetQualityLevel(4);
            graphicsText.text = "Quality: Highest";
            Debug.Log(QualitySettings.GetQualityLevel());
        }
        if (graphics.value == 6)
        {
            QualitySettings.SetQualityLevel(5);
            graphicsText.text = "Quality: Ultra";
            Debug.Log(QualitySettings.GetQualityLevel());
        }
    }
    public void FullScreenToggle()
    {
        /*
        @kimberly: this could be condensed into a shorter
                   statement by assigning Screen.fullScreen to its inverse

                   Screen.fullScreen = !Screen.fullScreen;
        */
        if(Screen.fullScreen == true)
        {
            Screen.fullScreen = false;
        }
        else
        {
            Screen.fullScreen = true;
        }
    }
}
