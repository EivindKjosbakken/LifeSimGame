using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home1Screen : MonoBehaviour
{

    public generalInfoTextScript gis;


    public selfTimeController tc;

   

    public GameObject home1ScreenUI;


   
    public void Sleep1()
    {
        if (Data.energy < 100)
        {
            Debug.Log("Home 1 scren");
            Data.energy += 15;
            //elapse some time

            //Data.daysPassed += 0.4f;
            tc.changeTime(0.4f);
            gis.ShowText("You slept");
            
            
        }
        else
            {
                gis.ShowText("You can't sleep anymore");
            }
    }

   
    public void resumeFromHome1Screen()
    {
        home1ScreenUI.SetActive(false);
        Time.timeScale = 1f;
    }

}
