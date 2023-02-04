using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;


    public void OpenPanelGame()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void OpenPanelGameClose()
    {
        Time.timeScale = 0;

        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }


}
