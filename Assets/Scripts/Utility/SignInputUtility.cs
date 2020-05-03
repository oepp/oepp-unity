using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SignInputUtility
{
    public static bool CanSignIn(string userName, string password)
    {
        return !userName.Equals("") && !password.Equals("");
    }

    public static bool CanSignUp(string name, string surname, string username, string email, string password, string passwordRety)
    {
        return !name.Equals("") && !surname.Equals("") && !username.Equals("") && !email.Equals("") && !password.Equals("") && (password.Equals(passwordRety));
    }
}
