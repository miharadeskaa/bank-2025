class Bank(Dictionary<string, CurrentAccount> accounts,string name)
{
    public Dictionary<string, CurrentAccount> Accounts { get;  private set; } = accounts;
    public string Name { get; set; } = name;



    public void AddAccount(CurrentAccount account)
    {
        if (Accounts.ContainsKey(account.Nombre))
        {
            Console.WriteLine("Ce compte existe déja !");
        }
        else
        {
            Accounts.Add(account.Nombre, account);
        }
    }

    public void RemoveAccoun(CurrentAccount account, string nombre)
    {
        if (Accounts.ContainsKey(nombre))
        {
            Accounts.Remove(account.Nombre);
            Console.WriteLine("Le compte est supprimé.");
        }
        else
        {
            Console.WriteLine("Compte inexistant !");
        }
    }

    public void GetBalance(string nombre)
    {
        if (Accounts.ContainsKey(nombre))
        {
            Console.WriteLine($"Le solde du compte {nombre} est de {Accounts[nombre].Balance}.");
        }
        else
        {
            Console.WriteLine("Compte inexistant !");

        }
    }
    
    public void GetAccountInfo(Person user)
    {
        double totalBalance = 0;
        bool hasAccount = false;
        foreach (var account in Accounts.Values)
        {
            if (account.owner == user)
            {
                Console.WriteLine($"Compte: {account.Nombre} : Solde: {account.Balance}, Ligne de crédit: {account.creditline}");
                totalBalance += account.Balance;
                hasAccount = true;
            }
        }
        if (!hasAccount)
        {
            Console.WriteLine("Aucun compte trouvé pour cet utilisateur.");
        }
        else
        {
            Console.WriteLine($"Solde total pour {user.FirstName} {user.LastName}: {totalBalance}");
        }
    }

    public void RemoveAccount(CurrentAccount account1)
    {
        throw new NotImplementedException();
    }
}