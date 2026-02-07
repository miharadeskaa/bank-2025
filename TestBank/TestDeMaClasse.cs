using Xunit;
using TestBank;

public class TestDeMaClasse
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var maClasse = new MaClasse();

        // Act
        var result = maClasse.MaMethode();

        // Assert
        Assert.Equal(expected: "Résultat attendu", actual: result);
    }

    
// Tests unitaires pour vérifier les fonctionnalités du depot et de retrait 

    [Fact]
    public void TestDepotEtRetrait()
    {
        // Arrange
        var compte = new CompteBancaire("Mon Compte", 1000);
        var montantDepot = 500;
        var montantRetrait = 200;

        // Act
        compte.Deposer(montantDepot);
        compte.Retirer(montantRetrait);

        // Assert
        Assert.Equal(expected: 1300, actual: compte.Solde);
    }


// Verifier que le virement fonctionne entre les deux comptes 
    [Fact]
    public void TestVirement()
    {
        // Arrange
        var compteA = new CompteBancaire("Compte A", 1000);
        var compteB = new CompteBancaire("Compte B", 500);
        var montantVirement = 200;

        // Act
        compteA.Virer(compteB, montantVirement);

        // Assert
        Assert.Equal(expected: 800, actual: compteA.Solde);
        Assert.Equal(expected: 700, actual: compteB.Solde);
    }   

}
