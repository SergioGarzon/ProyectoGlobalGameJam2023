using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderLife : MonoBehaviour
{
    public Slider sldLife;
    public Image imgSliderFill;

    public LifeData lifeData;

    private OpenPanel openPanel;

    private SoundGamePlay soundPlayGame;

    private void Start()
    {
        sldLife.value = lifeData.life;

        openPanel = gameObject.GetComponent<OpenPanel>();

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

        if (lifeData.life == 0)
        {
            openPanel.OpenPanelGameClose();
            soundPlayGame.StartAudioGameOver();
        }        

        sldLife.value = lifeData.life;
    }

    public void ColorSlider()
    {
        if(lifeData.life >= 70)
        {
            imgSliderFill.color = Color.cyan;
        }

        if(lifeData.life >= 50 && lifeData.life < 70)
        {
            imgSliderFill.color = Color.yellow;
        }

        if (lifeData.life < 50 && lifeData.life >= 20)
        {
            imgSliderFill.color = Color.magenta;
        }

        if (lifeData.life < 20)
        {
            imgSliderFill.color = Color.red;
        }
    }
}
