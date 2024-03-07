
using System.Numerics;
using StringCalculator;

public class StringCalculatorTest
{
    [Fact]
    public void QuatrePlusUn()
    {
        var parts = new int[] { 4, 1 };
        var input = string.Join(",", parts);

        var resultat = Calculator.Add(input);
    }

    //prend plus de deux nombre 
    [Fact]
    public void QuatrePlusUnplusdeux()
    {
        var parts = new int[] {4,1,2};
        var input = string.Join(",", parts);

        var resultat = Calculator.Add(input);
    }

    // pour les espaces
    [Fact]
    public void QuatrePlusTroisplusdeux()
    {
        var parts = new int[] {4,3,2 };
        var input = string.Join(" , ", parts);

        var resultat = Calculator.Add(input);
    }

}

