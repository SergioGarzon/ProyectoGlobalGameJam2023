using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventsUI : MonoBehaviour
{
    public Button btnObjectEasy;
    public Button btnObjectMedium;
    public Button btnObjectHard;

    //Button Easy
    public Sprite image1SpriteHover;
    public Sprite image1SpritePress;
    public Sprite image1SpriteSelected;
    public Sprite image1SpriteIdle;

    //Button Medium
    public Sprite image2SpriteHover;
    public Sprite image2SpritePress;
    public Sprite image2SpriteSelected;
    public Sprite image2SpriteIdle;
       
    //Button Hard
    public Sprite image3SpriteHover;
    public Sprite image3SpritePress;
    public Sprite image3SpriteSelected;
    public Sprite image3SpriteIdle;

    public int typeButton;  //1 Easy, 2 Medium, 3 Hard


    private void Start()
    {
        
    }

    public void StartOptions()
    {
        switch(typeButton)
        {
            case 1: btnObjectEasy.image.sprite = image1SpriteSelected;
                    btnObjectMedium.image.sprite = image2SpriteIdle;
                    btnObjectHard.image.sprite = image3SpriteIdle;
                    break;
            case 2: btnObjectMedium.image.sprite = image2SpriteSelected;
                    btnObjectEasy.image.sprite = image1SpriteIdle;
                    btnObjectHard.image.sprite = image3SpriteIdle;
                    break;
            case 3: btnObjectHard.image.sprite = image3SpriteSelected;
                    btnObjectMedium.image.sprite = image2SpriteIdle;
                    btnObjectHard.image.sprite = image1SpriteIdle;
                    break;
        }
        
    }

    public void setImagenHover()
    {
        switch (typeButton)
        {
            case 1: btnObjectEasy.image.sprite = image1SpriteHover;
                    break;

            case 2: btnObjectMedium.image.sprite = image2SpriteHover;
                    break;

            case 3: btnObjectHard.image.sprite = image3SpriteHover;
                    break;
        }
    }

    public void setImagenPress()
    {
        switch (typeButton)
        {
            case 1: btnObjectEasy.image.sprite = image1SpritePress;
                    btnObjectMedium.image.sprite = image2SpriteIdle;
                    btnObjectHard.image.sprite = image3SpriteIdle;
                    break;
            case 2: btnObjectMedium.image.sprite = image2SpritePress;
                    btnObjectEasy.image.sprite = image1SpriteIdle;
                    btnObjectHard.image.sprite = image3SpriteIdle;
                    break;
            case 3: btnObjectHard.image.sprite = image3SpritePress;
                    btnObjectEasy.image.sprite = image1SpriteIdle;
                    btnObjectMedium.image.sprite = image2SpriteIdle;
                    break;
        }
    }
}
