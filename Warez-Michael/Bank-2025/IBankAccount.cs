/*
Définir l'interface IBankAccount et invoquer la methode ApplyInterest et d' offrir l'
accès en lecture au "Owner" et au "Number"
*/
public interface IBankAccount
{
    string Number { get; set; }
    double Balance { get; }

    void Deposit(double amount);
    void Withdraw(double amount);
    void ApplyInterest();
    
}

