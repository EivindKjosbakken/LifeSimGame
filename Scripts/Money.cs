using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text moneyText;
    //private int currentMoney = 0;





    // Update is called once per frame



     void Start()
    {
        moneyText.text = Data.money.ToString("0") ;
    }

    public void Deposit(int amount)
    {
        Data.money += amount;
        // currentMoney += amount;
        moneyText.text = Data.money.ToString("0");
        
    }


    public void Withdraw(int amount)
    {
        
        //currentMoney -= amount;
        moneyText.text = Data.money.ToString("0");
        
    }
}
