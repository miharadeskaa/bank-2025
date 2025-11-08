/*
Définir l'interface IBankAccount et invoquer la methode ApplyInterest et d' offrir l'
accès en lecture au "Owner" et au "Number"
*/
interface IBankAccount
{
    string Number { get; }
    public void ApplyInterest();
    Person Owner { get; set; }
}

