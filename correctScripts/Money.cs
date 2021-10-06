using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Money : MonoBehaviour
{


    public float everySecondAmount = 0f;

    public float salary = 0f;


  

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("depositPerSecond", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void deposit(float amount)
    {
        Data.money += amount;
    }

    /*
    public void depositPerSecond(float everySecondAmount)
    {
        Data.money += everySecondAmount;
    }
    */

    public void withdraw(float amount)
    {
        Data.money -= amount;
    }


}
