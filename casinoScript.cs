using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casinoScript : MonoBehaviour
{

    public generalInfoTextScript gis;

    public GameObject casinoUI;

   
    public void exitCasino()
    {
        casinoUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public bool determineIfWin()
    {
        
        int num = Random.Range(0, 2);
        //Debug.Log(num);
        if (num == 1)
        {
            return true;
        }
        else if (num == 0)
        {
            return false;
        }
        else
        {
            //Debug.Log("Noe er feil");
            return false;
        }
        
    }

    
    public void bet1()
    {
        if (Data.money > 49)
        {
            Data.money -= 50;
            if (determineIfWin())
            {
                Data.money += 100;
                Debug.Log("You won");
                gis.ShowText("You won");
                
                
            }
            else
            {
                Debug.Log("You lost");
                gis.ShowText("You lost");
                
                // write you lost in infotext
            }
        }
    }

    public void bet2()
    {
        if (Data.money > 99)
        {
            Data.money -= 100;
            if (determineIfWin())
            {
                Data.money += 200;
                Debug.Log("You won");
                gis.ShowText("You won");
                
                //Write you won in infotext
            }
            else
            {
                Debug.Log("You lost");
                gis.ShowText("You lost");
                
                // write you lost in infotext
            }
        }
    }
    public void bet3()
    {
        if (Data.money > 499)
        {
            Data.money -= 500;
            if (determineIfWin())
            {
                Data.money += 1000;
                Debug.Log("You won");
                gis.ShowText("You won");
              
                //Write you won in infotext
            }
            else
            {
                Debug.Log("You lost");
                gis.ShowText("You lost");
                
                // write you lost in infotext
            }
        }
    }

    public void bet4()
    {
        if (Data.money > 1999)
        {
            Data.money -= 2000;
            if (determineIfWin())
            {
                Data.money += 2000;
                Debug.Log("You won");
                gis.ShowText("You won");

                //Write you won in infotext
            }
            else
            {
                Debug.Log("You lost");
                gis.ShowText("You lost");

                // write you lost in infotext
            }
        }
    }












}
