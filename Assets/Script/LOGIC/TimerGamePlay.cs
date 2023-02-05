using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGamePlay : MonoBehaviour
{

    private int counterLife;

    private SliderLife sldLife;


    private void Start()
    {
        sldLife = gameObject.GetComponent<SliderLife>();
    }

    public void StartTimer()
    {
        counterLife = -2;

        Invoke("updateTimer", 1f);
    }

    public void stopTimer()
    {
        CancelInvoke();
    }

    private void updateTimer()
    {
        
        sldLife.updateLife(counterLife);
        sldLife.ColorSlider();
        Invoke("updateTimer", 1f);
    }
    
}
