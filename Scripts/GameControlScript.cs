using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour
{
    private const float V = 0.20f; //ny
    public GameObject player;
    public GameObject redPlayer;
    public GameObject ninjaPlayer;

    public CinemachineVirtualCamera vcam;
    

    //public GameObject ninjaPlayer;

    private string activeCharacter = "player";

    bool redIsBought = false;
    bool ninjaIsBought = false;




    public Text storeInfoText;

    public Text moneyText;

    int whichCharacter = 1;

    // Start is called before the first frame update
    void Start()
    {
        player.gameObject.SetActive(true);
        redPlayer.gameObject.SetActive(false); //trenger nok ikke denne linja
    }


    // burde fikse på de metodene under dersom du skal legge inn flere karakterer
    // og du må lagre det som er den faktiske playeren i lagresystemet



    public void BuyRedSkin()
    {
        if (Data.money>= 50)
        {
            Data.money -= 50;
            redIsBought = true;
            storeInfoText.text = "Red fox skin bought!";
            moneyText.text = Data.money.ToString("0");
        }
        else
        {
            storeInfoText.text = "You need more money to buy the skin";

        }
    }

    public void BuyNinjaSkin()
    {
        if (Data.money >= 100)
        {
            Data.money -= 100;
            ninjaIsBought = true;
            storeInfoText.text = "Ninja skin bought!";
            moneyText.text = Data.money.ToString("0");

        }
        else
        {
            storeInfoText.text = "You don't have the funds to buy the skin";
        }
    }

    public void SwitchToRedPlayer()
    {

        if (redIsBought)
        {
            if (activeCharacter == "player")
            {
                player.gameObject.SetActive(false);
            }
            else if (activeCharacter == "ninjaPlayer")
            {
                ninjaPlayer.gameObject.SetActive(false);         //burde byttes til noe som bare direkte disabler den aktive playeren
            }

            Data.whichCharacterIsActive = "redPlayer";

            redPlayer.gameObject.SetActive(true);
            activeCharacter = "redPlayer";
            storeInfoText.text = "Red fox skin equipped!";
            vcam.Follow = redPlayer.transform;
           
            var composer = vcam.GetCinemachineComponent<CinemachineFramingTransposer>(); //ny linje her og den under, gjør at kamera
            composer.m_DeadZoneWidth = V;

        }
        else
        {
            storeInfoText.text = "You don't have the red fox skin";
        }


    }


    public void SwitchToPlayer()
    {

        if (activeCharacter == "redPlayer")
        {
            redPlayer.gameObject.SetActive(false);
        }
        else if (activeCharacter == "ninjaPlayer")
        {
            ninjaPlayer.gameObject.SetActive(false);
        }

        Data.whichCharacterIsActive = "player";
        
        player.gameObject.SetActive(true);
        activeCharacter = "player";
        storeInfoText.text = "Normal player skin equipped";
        var composer = vcam.GetCinemachineComponent<CinemachineFramingTransposer>(); //ny linje her og den under, gjør at kamera
        composer.m_DeadZoneWidth = V;
    }


    public void SwitchToNinjaPlayer()
    {

        if (ninjaIsBought)
        {
            if (activeCharacter == "player")
            {
                player.gameObject.SetActive(false);
            }
            else if (activeCharacter == "redPlayer")
            {
                redPlayer.gameObject.SetActive(false);
            }

            Data.whichCharacterIsActive = "ninjaPlayer";

            ninjaPlayer.gameObject.SetActive(true);
            activeCharacter = "ninjaPlayer";
            storeInfoText.text = "Putting on the ninja suit!";
            vcam.Follow = ninjaPlayer.transform;
            var composer = vcam.GetCinemachineComponent<CinemachineFramingTransposer>(); //ny linje her og den under, gjør at kamera
            composer.m_DeadZoneWidth = V; //setting deadwidth with the new camera

        }
        else
        {

            storeInfoText.text = "You have not bought the ninja skin";
            
        }
    }
}
