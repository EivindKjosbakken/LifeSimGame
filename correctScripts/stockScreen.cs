using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class stockScreen : MonoBehaviour
{

    public generalInfoTextScript gis;


    public Money money;

    



    public void buy1()
    {
        if (Data.money > 99)
        {
            Data.money -= 100;
            
            Data.invested1 += 100;
            Data.ownedStocks[0] += 1;
            gis.ShowText("You bough a Circkle K stock");
            Debug.Log("Invested in stocks is"+ Data.invested1);
            Debug.Log(Data.invested1);
        }
        else
        {
            gis.ShowText("You can't afford this stock");
        }
    }

    public void buy2()
    {
        if (Data.money > 199)
        {
            Data.money -= 200;
            Data.invested2 += 200;
            Data.ownedStocks[1] += 1;
            gis.ShowText("You bought an Amazon stock");
        }
        else
        {
            gis.ShowText("You can't afford this stock");
        }
    }

    public void buy3()
    {
        if (Data.money > 499)
        {
            Data.money -= 500;
            Data.invested3 += 500;
            Data.ownedStocks[2] += 1;
            gis.ShowText("You bought a Google stock");
        }
        else
        {
            gis.ShowText("You can't afford this stock");
        }
    }

    public void buy4()
    {
        if (Data.money > 999)
        {
            Data.money -= 1000;
            Data.invested4 += 1000;
            Data.ownedStocks[3] += 1;
            gis.ShowText("You bought a DNB stock");
        }
        else
        {
            gis.ShowText("You can't afford this stock");
        }
    }


    public void sell1()
    {
        Debug.Log("1");
        if (Data.ownedStocks[0] > 0)
        {
            Debug.Log("2");
            Data.money += Data.invested1 / Data.ownedStocks[0];
            Data.invested1 -= Data.invested1 / Data.ownedStocks[0];
            Data.ownedStocks[0] -= 1;
            
            
            gis.ShowText("You sold a Cirkle K stock");
        }
    }

    public void sell2()
    {
        if (Data.ownedStocks[1] > 0)
        {
            Data.money += Data.invested2 / Data.ownedStocks[1];
            Data.invested2 -= Data.invested2 / Data.ownedStocks[1];
            Data.ownedStocks[1] -= 1;
            
            
            gis.ShowText("You sold an Amazon stock");
        }
    }

    public void sell3()
    {
        if (Data.ownedStocks[2] > 0)
        {

            Data.money += Data.invested3 / Data.ownedStocks[2];
            Data.invested3 -= Data.invested3 / Data.ownedStocks[2];
            Data.ownedStocks[2] -= 1;
            
            
            gis.ShowText("You sold a Google stock");
        }
    }

    public void sell4()
    {
        if (Data.ownedStocks[3] > 0)
        {
            Data.money += Data.invested4 / Data.ownedStocks[3];
            Data.invested4 -= Data.invested4 / Data.ownedStocks[3];
            Data.ownedStocks[3] -= 1;
            
            gis.ShowText("You sold a DNB stock");
        }
    }


}
