using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignInScreen : MonoBehaviour
{
    public InputField userName;

    public InputField password;

    public Button signInButton;

    public Button homeButton;

    private void Start()
    {
        RenderButtons();
    }

    void RenderButtons()
    {
        signInButton.onClick.AddListener(()=>OnSignInButtonPressed());
        homeButton.onClick.AddListener(()=> OnHomeButtonPressed());
    }

    private void OnSignInButtonPressed()
    {
        string _userName = userName.text;
        string _password = password.text;

        if (SignInputUtility.CanSignIn(_userName, _password))
        {
            Account account = new Account(_userName, _password);

            FindObjectOfType<SignController>().SignIn(account);
        }
        else
        {
            Debug.Log("Fill Correctly inputs");            
        }
    }

    public void OnHomeButtonPressed()
    {
        FindObjectOfType<NonUserUIController>().OpenOpenScreen();
        FindObjectOfType<NonUserUIController>().CloseSignInScreen();
    }
}
