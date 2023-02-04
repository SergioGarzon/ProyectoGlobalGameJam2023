using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderConfiguration : MonoBehaviour
{

    public Slider sldVolumen;

    public void setSliderValue()
    {
        float cantidad = PlayerPrefs.GetFloat("ValorSlider", 0);

        sldVolumen.value = cantidad;
    }

    public float getSliderValue()
    {
        float cantidad = sldVolumen.value;

        PlayerPrefs.SetFloat("ValorSlider", cantidad);
        PlayerPrefs.Save();

        return cantidad;
    }
   
}
