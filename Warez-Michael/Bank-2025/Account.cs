class Account(string nombre, double balance, Person owner)
{
    private string Nombre { get; set; } = nombre;
    private double Balance { get; set; } = balance;
    private Person owner { get;  set; } = owner;

    public virtual void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Le montant du retrait doit être supérieur à zéro.");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Fonds insuffisants pour le retrait.");
        }
        Balance -= amount;
    }
    
    public virtual void Deposit(double amount)
{
    if (amount <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(amount), "Le montant du dépôt doit être supérieur à zéro.");
    }

    Balance += amount;
}

    // Constructeur avec le numéro et le titulaire
    //et le numéro, le titulaire et le solde comme paramètres
    private Account(string nombre, Person owner) : 
        this(nombre, 0.0, owner)
    {
    }

}