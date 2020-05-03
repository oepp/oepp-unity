using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HttpRequestController : MonoBehaviour
{
    string mysqlUserName = "emreedemir";

    string mysqlPassword = "emreedemir";

    private string signInURL = "http://localhost:3001/user/login";

    private string signUpURL = "http://localhost:3001/user/register";

    public void SendSignUpRequest(Account account)
    {
        StartCoroutine(SignUpCoroutine(account));
    }

    public void SendSignInRequest(Account account)
    {
        StartCoroutine(SignInCoroutine(account));
    }

    IEnumerator SignInCoroutine(Account account)
    {
        Debug.Log("Sign In Coroutine Started");

        WWWForm form = new WWWForm();

        form.AddField("username", account.username);

        form.AddField("password", account.password);

        WWW wWW = new WWW(signInURL, form);

        yield return wWW;

        Debug.Log("Www result is" + wWW.text);

        Debug.Log("Sign Up Coroutine Stopped");

        Debug.Log("www error is" +wWW.error);
        if (wWW.)
        {
            FindObjectOfType<SignController>().OnSignInSuccesfull(account);
        }
        else
        {
            FindObjectOfType<SignController>().OnNetworkConnectionError();
        }
    }

    IEnumerator SignUpCoroutine(Account account)
    {
        Debug.Log("Sign Up Coroutine Started");

        WWWForm form = new WWWForm();

        form.AddField("name", account.name);

        form.AddField("surname", account.surname);

        form.AddField("password", account.password);

        form.AddField("email", account.email);

        form.AddField("username", account.username);

        WWW wWW = new WWW(signUpURL, form);

        yield return wWW;

        Debug.Log("result is" + wWW.text);
        Debug.Log("Sign Up Coroutine Stopped");
        Debug.Log("www error is" + wWW.error);
        if (wWW.text == "0")
        {
            FindObjectOfType<SignController>().OnSignInSuccesfull(account);
        }
        else
        {
            FindObjectOfType<SignController>().OnNetworkConnectionError();
        }
    }
}
