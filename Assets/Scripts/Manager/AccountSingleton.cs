using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountSingleton :Singleton<AccountSingleton>
{
    public Account account { get; private set; }

    public void SetAccount(Account account)
    {
        this.account = account;
    }

    public void SetAccountNull()
    {
        this.account = null;
    }

    public bool IsValidAccount()
    {
        return account != null;
    }
}
