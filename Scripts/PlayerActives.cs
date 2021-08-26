using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActives : MonoBehaviour
{


    public Transform StorePoint; //ekstra

    public GameManager gameManager; //ekstra

    public Money money;  //ekstra

    public GameObject storeUI;

    public GameObject store;

    private int penger = 0;

    public Text moneyText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            gameManager.CloseStoreUI();
            
        }

        if (Input.GetKeyDown(KeyCode.G) && storeUI.activeSelf == false)
        {
            OpenUI();

        }


        if (Input.GetKeyDown(KeyCode.Y))
        {
            money.Deposit(10);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            money.Withdraw(10);

        }

    }
    

   


    void OpenUI()
    {
        Collider2D[] items = Physics2D.OverlapCircleAll(StorePoint.position, 4);

        foreach (Collider2D o in items)
        {
            gameManager.OpenStoreUI();
            

            //prøve å endre på layers hvis det ikke funker
        }



    }
}
