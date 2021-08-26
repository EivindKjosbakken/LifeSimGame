using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{

    public Money m;
    public PlayerActives pa;
    public SpriteRenderer sr;
    

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag == "Coin")
        {
            
            
            m.Deposit(10);
            sr.enabled = false;
            Destroy(this);
        }
    }
}
