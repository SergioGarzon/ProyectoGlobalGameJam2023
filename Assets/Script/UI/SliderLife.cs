using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderLife : MonoBehaviour
{
    public Slider sldLife;
    public Text txtLife;
    public Image imgSliderFill;

    public LifeData lifeData;


    private void Start()
    {
        sldLife.value = lifeData.life;
        txtLife.text = lifeData.life + "%";

        ColorSlider();
    }

    public void updateLife(int valueLife)
    {        
        lifeData.life += valueLife;        

        if(lifeData.life > 100)
        {
            lifeData.life = 100;
        }

        if(lifeData.life < 0)
        {
            lifeData.life = 0;
        }

        sldLife.value = lifeData.life;
        txtLife.text = lifeData.life + "%";
    }

    public void ColorSlider()
    {
        if(lifeData.life > 50)
        {
            imgSliderFill.color = Color.green;
        }

        if (lifeData.life <= 50 && lifeData.life > 20)
        {
            imgSliderFill.color = Color.yellow;
        }

        if (lifeData.life < 20)
        {
            imgSliderFill.color = Color.red;
        }
    }
}
