using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NonUserUIController : MonoBehaviour
{
    public OpenScreen openScreen;

    public SignInScreen signInScreen;

    public SignUpScreen signUpScreen;

    public Text messageBox;

    public void OpenOpenScreen()
    {
        openScreen.gameObject.SetActive(true);
    }

    public void CloseOpenScreen()
    {
        openScreen.gameObject.SetActive(false);
    }

    public void OpenSignInScreen()
    {
        signInScreen.gameObject.SetActive(true);
    }

    public void OpenSignUpScreen()
    {
        signUpScreen.gameObject.SetActive(true);
    }

    public void CloseSignUpScreen()
    {
        signUpScreen.gameObject.SetActive(false);
    }

    public void CloseSignInScreen()
    {
        signInScreen.gameObject.SetActive(false);
    }

    public void ViewMessage(string message)
    {
        StartCoroutine(MessageBoxCoroutine(message));
    }

    IEnumerator MessageBoxCoroutine(string message)
    {
        messageBox.gameObject.SetActive(true);
        messageBox.text = message;

        yield return new WaitForSeconds(3f);

        messageBox.text = "";
        messageBox.gameObject.SetActive(false);
    }
}
