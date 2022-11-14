using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    bool active = true;

    public GameObject settingsPanel;
    public GameObject menuPanel;

    public void OnStart()
    {
        CloseSettings();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        //PlayerMovement.Start();

    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        menuPanel.SetActive(false);

    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void ExitGame()
    {
        /* Debug.LOG("Quitting Game");*/
        Application.Quit();
    }
    
}
