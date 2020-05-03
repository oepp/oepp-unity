using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignController : MonoBehaviour
{
    HttpRequestController httpRequestController;
    NonUserUIController nonUserUIController;

    private void Start()
    {
        httpRequestController = FindObjectOfType<HttpRequestController>();
        nonUserUIController = FindObjectOfType<NonUserUIController>();
    }

    public void SignUp(Account account)
    {
        httpRequestController.SendSignUpRequest(account); 
    }

    public void SignIn(Account account)
    {
        httpRequestController.SendSignInRequest(account);
    }

    public void OnSignInSuccesfull(Account account)
    {
        AccountSingleton.Instance.SetAccount(account);

        AppManager.Instance.SetUserScene();
    }

    public void OnNetworkConnectionError()
    {
        nonUserUIController.ViewMessage("Network Connection Failed");
    }
}
