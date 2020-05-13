using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Account 
{
    public string name { get; set; }

    public string surname { get; set; }

    public string email { get; set; }

    public string username { get; private set; }

    public string password { get; private set; }

    //Sing In Constructor
    public Account(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    //Sign Up Constructor
    public Account(string name, string surname, string username, string email, string password)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.username = username;
        this.password = password;
    }

    public override string ToString()
    {
        return "Name =" + name + " Surname =" + surname + " Email=" + email + " Username = " + username + " Password = " + password;
    }
}
