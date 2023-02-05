using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGamePlay : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;

    private void Start()
    {
        float cantidad = PlayerPrefs.GetFloat("ValorSlider", 0);

        audio1.volume = cantidad;
        audio2.volume = cantidad;
        audio3.volume = cantidad;
        audio4.volume = cantidad;

        IniciarAudio();
    }

    public void IniciarAudio()
    {
        audio1.Play();
        audio2.Play();
        audio3.Play();
    }

    public void StartSoundWater()
    {
        audio1.Stop();
        audio2.Stop();
        audio3.Stop();
        

        audio4.Play();
    }
}
