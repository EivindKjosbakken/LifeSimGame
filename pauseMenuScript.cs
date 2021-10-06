using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuScript : MonoBehaviour
{


    public GameObject pauseMenuUI;

    public GameObject settingsUI;

    public void openPauseMenu()
    {
        if (!pauseMenuUI.activeSelf)
        {
            pauseMenuUI.SetActive(true);
        }
    }

    public void closePauseMenuUI()
    {
        if (pauseMenuUI.activeSelf)
        {
            pauseMenuUI.SetActive(false);
        }
    }

    public void openSettingsUI() 
    {
        if (!settingsUI.activeSelf)
        {
            settingsUI.SetActive(true);
        }

    }

    public void quitApplication()
    {
        Application.Quit();
    }
}
