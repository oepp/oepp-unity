using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenScreen : MonoBehaviour
{
    public Button signInScreen;

    public Button signUpScreen;

    private void Start()
    {
        RenderButtons();
    }

    void RenderButtons()
    {
        signInScreen.onClick.AddListener(() => OnSignInScreenButtonPressed());

        signUpScreen.onClick.AddListener(() => OnSignUpScreenButtonPressed());
    }

    public void OnSignInScreenButtonPressed()
    {
        FindObjectOfType<NonUserUIController>().OpenSignInScreen();
        FindObjectOfType<NonUserUIController>().CloseOpenScreen();
    }

    public void OnSignUpScreenButtonPressed()
    {
        FindObjectOfType<NonUserUIController>().OpenSignUpScreen();
        FindObjectOfType<NonUserUIController>().CloseOpenScreen();
    }
}
