using System;
using Xunit;
using Projeto_Principal;

namespace Tests;

public class UnitTest1
{

    public Calculadora construirClasse()
    {
        string data = "26/02/2024";
        Calculadora calc = new Calculadora("26/02/2024");
        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.somar(num1 , num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(10, 5, 5)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.subtrair(num1 , num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.multiplicar(num1 , num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.dividir(num1 , num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TesteDividirPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );
    }
    [Fact]
    public void TesteHistorico()
    {
        Calculadora calc = construirClasse();

        calc.somar(1,2);
        calc.somar(3,2);
        calc.somar(5,2);
        calc.somar(2,7);
        

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3,lista.Count);

        
        
    }


}