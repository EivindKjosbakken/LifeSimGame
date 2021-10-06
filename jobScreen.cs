using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jobScreen : MonoBehaviour
{
    public generalInfoTextScript gis;

    public selfTimeController tc;


    public GameObject jobScreenUI;


    public void openJobScreen()
    {
        jobScreenUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void exitJobScreen()
    {
        jobScreenUI.SetActive(false);
        Time.timeScale = 1f;
    }


    public void applyGarbage()
    {
        Debug.Log("You got the job!");
        gis.ShowText("You became a garbage man!");
    }

    public void applyChef()
    {
        if (Data.garbageManExperience > 50)
        {

            Data.unlockedJobs.Add(1);
            gis.ShowText("You became a chef!");
        }
        else
        {
            gis.ShowText("You need 50 experience");
        }
    }

    public void applySales()
    {
        if (Data.chefExperience > 100)
        {
            Debug.Log("Unlock job");
            Data.unlockedJobs.Add(1);
            gis.ShowText("You became a sales worker!");
        }
        else
        {
            gis.ShowText("You need 100 experience");
        }
    }

    public void applyDoctor()
    {
        if (Data.salesExperience > 200)
        {

            Data.unlockedJobs.Add(1);
            gis.ShowText("You became a doctor!");
        }
        else
        {
            gis.ShowText("You need 200 experience");
        }
    }

    public void workGarbage()
    {
        if (Data.energy > 24)
        {
            Data.energy -= 25;
            Data.money += 50;
            Data.garbageManExperience += 1;
            gis.ShowText("You worked as a garbage man!");
            //Data.daysPassed += 0.2f;
            tc.changeTime(0.2f);
        }
        else
        {

            gis.ShowText("You do not have the energy");
        }
    }

    public void workChef()
    {
        if (Data.energy > 19 && Data.unlockedJobs.Count > 0)
        {
            Data.energy -= 20;
            Data.money += 70;
            Data.chefExperience += 1;
            gis.ShowText("You worked as a chef!");
            //elapse some time
            //Data.daysPassed += 0.2f;
            tc.changeTime(0.2f);
        }
        else
        {
            gis.ShowText("You don't have the energy");
        }
    }

    public void workSales()
    {
        if (Data.energy > 19 && Data.unlockedJobs.Count > 1)
        {
            Data.energy -= 20;
            Data.money += 100;
            Data.salesExperience += 1;
            gis.ShowText("You worked in sales!");
            
            //Data.daysPassed += 0.3f;
            tc.changeTime(0.3f);
        }
        else
        {
            gis.ShowText("You don't have the energy");
        }
    }

    public void workDoctor()
    {
        if (Data.energy > 29 && Data.unlockedJobs.Count > 2)
        {
            Data.energy -= 30;
            Data.money += 100;
            Data.doctorExperience += 1;
            gis.ShowText("You worked as a doctor!");

            //Data.daysPassed += 0.4f;
            tc.changeTime(0.4f);
        }
        else
        {
            gis.ShowText("You don't have the energy");
        }


    }

    
}
