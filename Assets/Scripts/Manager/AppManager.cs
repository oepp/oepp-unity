using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : Singleton<AppManager>
{   
    void Awake()
    {
        if (AccountSingleton.Instance.IsValidAccount())
        {
            SetUserScene();
        }
        else
        {
            SetOpeningMenu();
        }
    }

    public void SetOpeningMenu()
    {
        FindObjectOfType<NonUserUIController>().OpenOpenScreen();
    }

    public void SetUserScene()
    {
        SceneManager.LoadScene("UserScene");
    }

    public void SetNonUserScene()
    {
        SceneManager.LoadScene("NonUserScene");
    }

    public void ExitAccount()
    {
        AccountSingleton.Instance.SetAccountNull();
    }
}
