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
}
