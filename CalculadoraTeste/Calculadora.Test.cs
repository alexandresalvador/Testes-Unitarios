namespace CalculadoraTeste;

public class UnitTest1
{
    Programa.Calculadora calculadora = new Programa.Calculadora();

    [Fact]
    public void TestSumTwoNumbers()
    {
        double result;

        result = calculadora.Somar(1, 2);
        Assert.Equal(3, result);

        result = calculadora.Somar(-1, 1);
        Assert.Equal(0, result);

        result = calculadora.Somar(1.1, 1);
        Assert.Equal(2.1, result);

        result = calculadora.Somar(0, 1);
        Assert.Equal(1, result);
    }

    [Fact]
    public void TestSubtractTwoNumbers()
    {
        double result;

        result = calculadora.Diminuir(5, 2);
        Assert.Equal(3, result);

        result = calculadora.Diminuir(-1, 1);
        Assert.Equal(-2, result);
        
        // deu erro nas casa decimais
        result = calculadora.Diminuir(5.1, 5.0);
        Assert.Equal(0.1, result);

        result = calculadora.Diminuir(0, -1.5);
        Assert.Equal(-1.5, result);
    }

    [Fact]
    public void TestMultiplyTwoNumbers()
    {
        double result;

        result = calculadora.Multiplicar(6, 2);
        Assert.Equal(12, result);

        result = calculadora.Multiplicar(-6, 1);
        Assert.Equal(-6, result);

        result = calculadora.Multiplicar(6.1, 1);
        Assert.Equal(6.1, result);

        result = calculadora.Multiplicar(0, 1.7);
        Assert.Equal(0, result);
    }

    [Fact]
    public void TestDivideTwoNumbers()
    {
        double result;

        result = calculadora.Dividir(6, 2);
        Assert.Equal(3, result);

        result = calculadora.Dividir(-1, 2);
        Assert.Equal(-0.5, result);

        result = calculadora.Dividir(1.2, 2);
        Assert.Equal(0.6, result);

        // sem checar, ele da erro e retorna infinito
        result = calculadora.Dividir(-7.6, 0);
        Assert.Equal(0, result);
    }
}