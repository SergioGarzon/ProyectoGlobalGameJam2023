using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEsc : MonoBehaviour
{
    public GameObject canvas;
    public GameObject camera;
    bool isPaused;

    private void Start()
    {
        
    }

    private void Update()
    {
        
        
            if (!isPaused)
            {
                isPaused = true;
                Pause();
            }
            else
            {
                isPaused = false;
                Resume();
            }
        
    }

    void Pause()
    {
        isPaused = true;
        canvas.SetActive(true);
        Time.timeScale = 0f;
    }

    void Resume()
    {
        isPaused = false;
        canvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
