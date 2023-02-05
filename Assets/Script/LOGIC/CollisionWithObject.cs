using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithObject : MonoBehaviour
{

    //public OpenPanel pnlWin;

    private GameObject objectLogic;

    private SliderLife sldLife;

    private SpawnObjectRoot spawnObjectRoot;

    private OpenScene openSceneGame;

    private SoundGamePlay soundGamePlay;


    private void Start()
    {
        //pnlWin = gameObject.GetComponent<OpenPanel>();

        objectLogic = GameObject.Find("Logic");

        sldLife = objectLogic.GetComponent<SliderLife>();

        spawnObjectRoot = objectLogic.GetComponent<SpawnObjectRoot>();

        openSceneGame = objectLogic.GetComponent<OpenScene>();

        soundGamePlay = objectLogic.GetComponent<SoundGamePlay>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "waterWall")
        {
            Time.timeScale = 0;
            openSceneGame.OpenSceneGame("FinalVideo");
        }

        if (other.gameObject.tag == "Object1")
        {
            sldLife.updateLife(5);
            sldLife.ColorSlider();
            Destroy(other.gameObject);            
        }

        if (other.gameObject.tag == "Object2")
        {
            sldLife.updateLife(10);
            sldLife.ColorSlider();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Object3")
        {
            sldLife.updateLife(15);
            sldLife.ColorSlider();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Object4")
        {
            sldLife.updateLife(-10);
            sldLife.ColorSlider();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Object5")
        {
            sldLife.updateLife(-15);
            sldLife.ColorSlider();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "WaterSound")
        {
            soundGamePlay.StartSoundWater();
        }



    }

}
