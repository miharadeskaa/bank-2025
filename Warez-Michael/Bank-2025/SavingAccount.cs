using System;

class SavingAccount
{
    public string Nombre { get; set; }
    public double Balance { get; private set; }
    public double InterestRate { get; private set; }
    public DateTime DateLastWithdraw { get; private set; }
    private Person owner;

    public SavingAccount(string nombre, double balance, double interestRate, Person owner)
    {
        Nombre = nombre;
        Balance = balance;
        InterestRate = interestRate;
        DateLastWithdraw = DateTime.MinValue;
        this.owner = owner;
    }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
    }

    public void Withdraw(double amount)
    {
        if ((DateTime.Now - DateLastWithdraw).TotalDays >= 30)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                DateLastWithdraw = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Solde insuffisant.");
            }
        }
        else
        {
            Console.WriteLine("Retrait refusé : vous devez attendre 30 jours entre deux retraits.");
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    // Constructeur simplifié
    public SavingAccount(string nombre, Person owner)
        : this(nombre, 0.0, 0.0, owner)
    {
    }
}
