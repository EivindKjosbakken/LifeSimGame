using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home2Script : MonoBehaviour
{
    public generalInfoTextScript gis;

    public selfTimeController tc;
    

    public GameObject home2UI;
    public void sleep2()
    {
        if (Data.energy < 100)
        {
            Data.energy += 25;
            //Data.daysPassed += 0.3f;
            tc.changeTime(0.3f);
            gis.ShowText("You slept and gained 25 energy");
        }
        else
        {
            gis.ShowText("You can't sleep anymore");
        }
    }

    public void resumeFromHome2()
    {
        Time.timeScale = 1f;
        home2UI.SetActive(false);

    }
}
