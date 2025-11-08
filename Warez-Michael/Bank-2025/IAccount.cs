/*
Définir l'interface IAccount afin de limiter l'acces à consulter la propriété Balance
et aux méthodes Deposit et Withdraw.
*/
public interface IAccount
{
    double balance { get; set; }
    void Withdraw(double amount);
    void Deposit(double amount);
}