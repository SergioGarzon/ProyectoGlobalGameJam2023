using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private TimerGamePlay timerGame;

    private bool control;

    void Start()
    {
        timerGame = gameObject.GetComponent<TimerGamePlay>();

        timerGame.StartTimer();

        control = true;
    }

    public void disabledPanel()
    {
        control = false;
    }

    public bool getControlData()
    {
        return control;
    }
}
