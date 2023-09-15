namespace Calculos.Tests;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void SomaRetornaValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Soma(10,20);
        Assert.AreEqual(30, resultado);
    }

    [TestMethod]
    public void SubtracaoRetornaValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Subtracao(50,30);
        Assert.AreEqual(20, resultado);
    }

    [TestMethod]
    public void MultiplicacaoRetornaValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Multiplicacao(5,2);
        Assert.AreNotEqual(15, resultado);
    }

    [TestMethod]
    public void DivisaoRetornaValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Divisao(10,5);
        Assert.AreEqual(2, resultado);
    }
}
