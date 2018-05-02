using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
   

    public Dropdown res;
    public Slider qSlider;
    public Text qText;

    private void Start()
    {
         Resolution[] resolution;
        resolution = Screen.resolutions;

        res.onValueChanged.AddListener(delegate { Screen.SetResolution(resolution[res.value].width, resolution[res.value].height,Screen.fullScreen); });

        for (int i = 0; i < resolution.Length; i++)
        {
            Dropdown.OptionData addedData = new Dropdown.OptionData(ResToString(resolution[i]));
            res.options.Add(addedData);
        }

        qSlider.maxValue = 6;
        qSlider.minValue = 1;
        QualitySettings.SetQualityLevel(0);

       
    }
   
    private string ResToString(Resolution RTS)
    {
        return RTS.width + " x " + RTS.height;
    }


   

    public void graphics()
    {
        Slider graphics = qSlider;
        Text graphicsText = qText;

        if (graphics.value == 1)
        {
            QualitySettings.SetQualityLevel(0);
            graphicsText.text = "Quality: Lowest";
        }
        if (graphics.value == 2)
        {
            QualitySettings.SetQualityLevel(1);
            graphicsText.text = "Quality: Low";
        }
        if (graphics.value == 3)
        {
            QualitySettings.SetQualityLevel(2);
            graphicsText.text = "Quality: Medium";
                 }
        if (graphics.value == 4)
        {
            QualitySettings.SetQualityLevel(3);
            graphicsText.text = "Quality: High";
        }
        if (graphics.value == 5)
        {
            QualitySettings.SetQualityLevel(4);
            graphicsText.text = "Quality: Highest";
        }
        if (graphics.value == 6)
        {
            QualitySettings.SetQualityLevel(5);
            graphicsText.text = "Quality: Ultra";
        }
    }
    public void FullScreenToggle()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}

