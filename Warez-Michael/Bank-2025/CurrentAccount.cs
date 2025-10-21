/*
creer une classe "CurrentAccount" qui permet la gestion d' un compte
propirété publique : Nombre,double balance(lecture seule), CreditLine ,Owner
methodes publiques : void Withdraw, void deposit(double amount)
*/

class CurrentAccount(string nombre,double balance, double creditline, Person Owner)

{
    public string Nombre { get; set; } = nombre;
    public double Balance { get; } = balance;
    public double creditline { get; set; } = creditline;

    public Person owner { get; set; } = Owner;
    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.Writline("Solde insufisant");
        }
        else
        {
           Balance -= amount;
        }
    }
    public void Deposit(double amount)
    {
        Balance += amount;
    }

}