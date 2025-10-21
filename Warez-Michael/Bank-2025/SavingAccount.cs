using System;

class SavingAccount(string nombre, double balance, double interestRate, Person owner)
{
    public string Nombre { get; set; } = nombre;
    public double Balance { get; private set; } = balance;
    public DateTime DateLastWithdraw { get; private set; } = DateLastWithdraw;
    public Person owner { get; private set; } = owner;

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("le solde est insuffisant.");
        }
        else
        {
            Balance -= amount;
            DateLastWithdraw = DateTime.Now;
        }
    }
    public void Deposit(double amount)
    {
        Balance += amount;
    }
}