using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Networking;

public class HttpRequestController : MonoBehaviour
{
    private string signInURL = "http://localhost:3001/user/login";

    private string signUpURL = "http://localhost:3001/user/register";

    private string popularGamesURL = "http://localhost:3001/infos/popular";

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

        WWW www = new WWW(signInURL, form);

        yield return www;

        SignResponseData result = JsonUtility.FromJson<SignResponseData>(www.text);

        if (result.status == "success")
        {
            FindObjectOfType<SignController>().OnSignInSuccesfull(account);
        }
        else
        {
            FindObjectOfType<SignController>().OnNetworkConnectionError(result.message);
        }
    }

    IEnumerator SignUpCoroutine(Account account)
    {
        Debug.Log(account.ToString());

        WWWForm form = new WWWForm();

        form.AddField("name", account.name);

        form.AddField("surname", account.surname);

        form.AddField("username", account.username);

        form.AddField("email", account.email);

        form.AddField("password", account.password);

        form.AddField("confirmpassword", account.password);

        WWW www = new WWW(signUpURL, form);

        yield return www;

        SignResponseData result = JsonUtility.FromJson<SignResponseData>(www.text);

        if (result.status == "success")
        {
            FindObjectOfType<SignController>().OnSignInSuccesfull(account);
        }
        else
        {
            FindObjectOfType<SignController>().OnNetworkConnectionError(www.text);
        }
    }

    IEnumerator PopulerCoursesCoroutine()
    {




        yield return new WaitForSeconds(1f);
    }


}
[System.Serializable]
class SignResponseData
{
    public string status;
    public string message;
}
