using System;

class Account(string nombre, double balance, Person owner)
{
    public string Nombre { get; set; } = nombre;
    public double Balance { get; protected set; } = balance;
    public Person owner { get; private set; } = owner;

    public virtual void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Le solde est insuffisant.");
        }
        else
        {
            Balance -= amount;
        }
    }
    public virtual void Deposit(double amount)
    {
        Balance += amount;
    }
}