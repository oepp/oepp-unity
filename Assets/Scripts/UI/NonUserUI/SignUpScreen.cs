using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignUpScreen : MonoBehaviour
{
    public InputField name;

    public InputField surname;

    public InputField userName;

    public InputField email;

    public InputField password;

    public InputField passwordRety;

    public Button signUpButton;

    public Button homeButton;

    private void Start()
    {
        RenderButtons();
    }

    void RenderButtons()
    {
        signUpButton.onClick.AddListener(() => OnSignUpButtonPressed());
        homeButton.onClick.AddListener(() => OnHomeButtonPressed());
    }

    private void OnSignUpButtonPressed()
    {
        if (SignInputUtility.CanSignUp(name.text, surname.text, userName.text, email.text, password.text, passwordRety.text))
        {
            Account newAccount = new Account(name.text, surname.text, userName.text, email.text, password.text);

            FindObjectOfType<SignController>().SignUp(newAccount);
        }
        else
        {
            Debug.Log("fill correctly");
        }
    }

    private void OnHomeButtonPressed()
    {
        FindObjectOfType<NonUserUIController>().OpenOpenScreen();
        FindObjectOfType<NonUserUIController>().CloseSignUpScreen();
    }
}






