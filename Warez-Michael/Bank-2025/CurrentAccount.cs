/*
creer une classe "CurrentAccount" qui permet la gestion d' un compte
propirété publique : Nombre,double balance(lecture seule), CreditLine ,Owner
methodes publiques : void Withdraw, void deposit(double amount)
*/

class CurrentAccount(string nombre, double balance, double creditline, Person Owner)

{
    public string Nombre { get; set; } = nombre;
    private double _balance = balance;
    public double Balance => _balance;
    private decimal _creditLine = (decimal)creditline;
    public Person owner { get; set; } = Owner;


    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Solde insufisant");
        }
        else
        {
            _balance -= amount;
        }
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }
    // Constructeur avec le numéro et le titulaire
    //et le numéro, le titulaire et le solde comme paramètres
    public CurrentAccount(string nombre, Person owner) :
        this(nombre, 0.0, 0.0, owner)
    {
    }
    private decimal creditLine;

public decimal CreditLine
{
    get { return creditLine; }
    set
    {
        if (value < 0)
        {
                throw new ArgumentOutOfRangeException(nameof(CreditLine),
                    "La valeur doit être supérieure ou égale à zéro.");
        }
        creditLine = value;
    }
}

}
