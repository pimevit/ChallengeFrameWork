using AppFrameWork.Application;
using AppFramWork.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AppFrameWorkTest
{
  [TestClass]
  public class CalcularDivisoresTest
  {
    /// <summary>
    /// Teste para validar o Valor de entrada de exemplo
    /// </summary>
    [TestMethod]
    public void CalcularDivisores_45()
    {
      ICalculoService calculo = new CalculoService();
      List<int> assert = new List<int>() { 1, 3, 5, 9, 15, 45 };
      var result = calculo.ObterDivisoresNumero(45);

      Assert.IsTrue(result.Count == 6);

      ValidarListaPreenchida(assert, result, result.Count);
    }

    private static void ValidarListaPreenchida(List<int> assert, List<int> result, int index)
    {
      for (int i = 0; i < index; i++)
      {
        Assert.AreEqual(assert[i], result[i], "Valores divergentes");

      }
    }

    [TestMethod]
    public void ValidarNumerosPrimos_Divisores45()
    {
      ICalculoService calculo = new CalculoService();

      List<int> assert = new List<int>() { 1, 3, 5 };
      var result = calculo.ObterNumerosPrimos(calculo.ObterDivisoresNumero(45));
      Assert.IsTrue(assert.Count == 3);
      ValidarListaPreenchida(assert,result, result.Count);
    }
    [TestMethod]
    public void ValidarEntradaNumeroZerado()
    {
      ICalculoService calculo = new CalculoService();
      Assert.ThrowsException<DivideByZeroException>(()=> calculo.ObterDivisoresNumero(0));
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void ListaNaoPodeSerVazia()
    {
      ICalculoService calculo = new CalculoService();
      calculo.ObterNumerosPrimos(new());
    }
    [TestMethod]
    public void NumeroPrimoMaiorqueUm()
    {
      ICalculoService calculo = new CalculoService();
      Assert.ThrowsException<ArgumentException>(() => calculo.IdentificarNumeroPrimo(1));
    }
  }
}
