using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DataReset : MonoBehaviour
{
    public Button btnEasy;
    public Button btnMedium;
    public Button btnHard;

    public void SetDifficulty()
    {

    }

    public void SaveSelectedDificulty(int value)
    {
        PlayerPrefs.SetInt("Difficulty", value);
        PlayerPrefs.Save();
    }





}
