using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject storeUI;

    public Money money;

    public Text currentMoney;

    private int saveMoney;


   

    public Transform playerPosition;

    public Transform spawnPositionRight;

    public Transform spawnPositionLeft;

    

    
    public PlayerMovement playerMovement;

    public static string WhichTrigger = "";



    bool gameHasEnded = false;

    float restartDelay = 1f;


   
    




    void OnEnable()
    {
        //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {


        

        if (WhichTrigger == "End")
        {
            playerPosition.position = spawnPositionLeft.position;
            WhichTrigger = "";
        }

        else if (WhichTrigger == "Start")
        {
            playerPosition.position = spawnPositionRight.position;
            WhichTrigger = "";
        }

        



    }



    public void OpenStoreUI()
    {
        
        storeUI.SetActive(true);
        playerMovement.enabled = false;
    }

    public void CloseStoreUI()
    {
        
        storeUI.SetActive(false);
        playerMovement.enabled = true;
        
    }
    


    public void NextLevel()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(Data.money);

    }

    public void PreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log(Data.money);
    }

    

    

    //Save things

    public void SaveGame()
    {
        PlayerPrefs.SetInt("SavedInteger", Data.money);

        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
    }
    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            saveMoney = PlayerPrefs.GetInt("SavedInteger");
            currentMoney.text = saveMoney.ToString("0");

            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }


    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Data.money -= Data.money;
        currentMoney.text = Data.money.ToString("0") ;

    }

}
