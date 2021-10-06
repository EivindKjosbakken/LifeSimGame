using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clothingshop : MonoBehaviour
{


    public generalInfoTextScript gis;

    public GameObject clothingUI;

    public SpriteRenderer sr;

    public Sprite baseSkin;
    public Sprite suitSkin;
    public Sprite skin3;
    public Sprite skin4;


    public void activateActiveSkin()
    {
        if (Data.activeSkin == 1)
        {
            equipBaseSkin();
        }
        if (Data.activeSkin == 2)
        {
            equipSuitSkin();
        }
        if (Data.activeSkin == 3)
        {
            equipSkin3();
        }
        if (Data.activeSkin == 4)
        {
            equipSkin4();
        }
    }

    public void buySuitSkin()
    {
        if (Data.money > 999)
        {
            Data.money -= 1000;
            Data.unlockedClothes[1] = true;
            gis.ShowText("You bought the suit skin");

        }
    }

   
    public void equipSuitSkin()
    {
        if (Data.unlockedClothes[1] == true)
        {
            sr.sprite = suitSkin;
            Data.activeSkin = 2;
            gis.ShowText("Equipped suitskin");
        }
        else
        {
            gis.ShowText("You don't own the skin");
        }
    }

    public void equipBaseSkin()
    {
        sr.sprite = baseSkin;
        gis.ShowText("Equipped baseskin");
    }

    public void equipSkin3()
    {
        sr.sprite = skin3;
        gis.ShowText("Equipped skin 3");
    }

    public void equipSkin4()
    {
        sr.sprite = skin4;
        gis.ShowText("Equipped skin 4");
    }



    public void resumeFromClothingUI()
    {
        Time.timeScale = 1f;
        clothingUI.SetActive(false);

    }
}
