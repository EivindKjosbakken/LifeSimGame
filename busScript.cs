using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class busScript : MonoBehaviour
{

    public generalInfoTextScript gis;

    
    public GameObject busUI;

    public GameManager gm;

    public void resumeFromBusUI()
    {

        busUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void buy2()
    {
        if (Data.money > 1999)
        {
            Data.money -= 2000;
            Data.unlockedAreas[1] = 1;
            gis.ShowText("Unlocked the suburbs");

        }
        else
        {
            gis.ShowText("You can't afford to unlock the area");
        }
    }

    public void buy3()
    {
        if (Data.money > 8999)
        {
            Data.money -= 9000;
            Data.unlockedAreas[2] = 1;
            gis.ShowText("Unlocked the residental area");

        }
        else
        {
            gis.ShowText("You can't afford to unlock the area");
        }
    }

    public void buy4()
    {
        if (Data.money > 12999)
        {
            Data.money -= 13000;
            Data.unlockedAreas[3] = 1;
            gis.ShowText("Unlocked the rich neighbourhood");

        }
        else
        {
            gis.ShowText("You can't afford to unlock the area");
        }
    }


    public void Travel1()
    {
        //sjekk om du allerede er der (med buildindexen) og om du har unlocka stedet

        if ((SceneManager.GetActiveScene().buildIndex != 0))
        {
            gm.loadLevel(0);
            busUI.SetActive(false);
            Time.timeScale = 1f;

        }      
        
        else
        {
            gis.ShowText("You are already here");
        }
    }

    public void Travel2()
    {
        //sjekk om du allerede er der (med buildindexen) og om du har unlocka stedet

        if ((SceneManager.GetActiveScene().buildIndex != 1) && Data.unlockedAreas[1] == 1) 
        {
            gm.loadLevel(1);
            busUI.SetActive(false);
            Time.timeScale = 1f;

        }
        else if (Data.unlockedAreas[1] == 0)
        {
            gis.ShowText("Not unlocked");
        }
        else
        {
            gis.ShowText("You are already here");
        }
    }

    public void Travel3()
    {
        //sjekk om du allerede er der (med buildindexen) og om du har unlocka stedet

        if ((SceneManager.GetActiveScene().buildIndex != 2) && Data.unlockedAreas[2] == 1)
        {
            gm.loadLevel(2);
            busUI.SetActive(false);
            
        }
        else if (Data.unlockedAreas[2] == 0)
        {
            gis.ShowText("Not unlocked");
        }
        else
        {
            gis.ShowText("You are already here");
        }
    }

    public void Travel4()
    {
        //sjekk om du allerede er der (med buildindexen) og om du har unlocka stedet

        if ((SceneManager.GetActiveScene().buildIndex != 3) && Data.unlockedAreas[3] == 1)
        {
            gm.loadLevel(3);
            busUI.SetActive(false);

        }
        else
        {
            gis.ShowText("You are already here");
        }


    }

    



}
