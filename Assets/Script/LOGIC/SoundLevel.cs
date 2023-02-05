using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLevel : MonoBehaviour
{
    public AudioSource audio;

    private void Start()
    {
        float cantidad = PlayerPrefs.GetFloat("ValorSlider", 0);

        audio.volume = cantidad;

        AudioStart();
    }

    public void AudioStart()
    {
        audio.Play();
    }

    public void StopAudio()
    {
        audio.Stop();
    }
}
