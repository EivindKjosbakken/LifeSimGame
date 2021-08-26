using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateMoney : MonoBehaviour
{



    public Money m;
    public Text moneyText;

    public PlayerActives pa;

    

    void OnTriggerEnter2D(Collider2D collision)
    {
        
            moneyText.text = Data.money.ToString("0");

        
           

        
        }
}
