using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
        WWWForm form = new WWWForm();

        form.AddField("username", account.username);

        form.AddField("password", account.password);

        WWW wWW = new WWW(signInURL, form);

        yield return wWW;

        SignResponseData result = JsonUtility.FromJson<SignResponseData>(wWW.text);

        if (result.status =="success")
        {
            FindObjectOfType<SignController>().OnSignInSuccesfull(account);
        }
        else
        {
            FindObjectOfType<SignController>().OnNetworkConnectionError(wWW.error);
        }
    }

    IEnumerator SignUpCoroutine(Account account)
    {
        WWWForm form = new WWWForm();

        form.AddField("name", account.name);

        form.AddField("surname", account.surname);

        form.AddField("password", account.password);

        form.AddField("email", account.email);

        form.AddField("username", account.username);

        WWW wWW = new WWW(signUpURL, form);

        yield return wWW;

        Debug.Log("result is" + wWW.text);

        SignResponseData result = JsonUtility.FromJson<SignResponseData>(wWW.text);

        if (result.status == "success")
        {
            FindObjectOfType<SignController>().OnSignInSuccesfull(account);
        }
        else
        {
            FindObjectOfType<SignController>().OnNetworkConnectionError(wWW.error);
        }
    }
}
[System.Serializable]
class SignResponseData
{
    public string status;
    public string message;
}
