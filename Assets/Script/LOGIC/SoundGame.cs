using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGame : MonoBehaviour
{
    public AudioSource audio;
    private SliderConfiguration sldConfiguration;

    private void Start()
    {
        audio.Play();

        sldConfiguration = GetComponent<SliderConfiguration>();
    }

    public void StartAudio()
    {
        audio.Play();
    }

    public void StartAudioVolume()
    {
        audio.volume = sldConfiguration.getSliderValue();
        audio.Play();
    }

    public void StopAudio()
    {
        audio.Stop();
    }

}
