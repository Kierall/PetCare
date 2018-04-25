using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    Resolution[] resolution;
   
    public Dropdown res;
    public Slider qSlider;
    public Text qText;

    private void Start()
    {
        resolution = Screen.resolutions;
       
        Res();
        qSlider.maxValue = 6;
        qSlider.minValue = 1;
        QualitySettings.SetQualityLevel(0);
    }
    void Res()
    {
        for(int i = 0; i <resolution.Length; i++)
        {
            Dropdown.OptionData addedData = new Dropdown.OptionData();
            addedData.text = ResToString(resolution[i]);
            res.options.Add(addedData);
        }
    }

    string ResToString(Resolution RTS)
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
}
