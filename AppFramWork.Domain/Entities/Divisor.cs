using System;
using System.Collections.Generic;


namespace AppFramWork.Domain.Entities
{
  public class Divisor
  {
    protected List<int> FatoresPrimos { get; set; }
    public List<int> Divisores { protected set; get; }

    NumeroPrimo NumererosPrimos { get; set; } = new NumeroPrimo();
    /// <summary>
    /// Decompando o número utilizando os fatores Primos.
    /// </summary>
    /// <param name="numero"></param>
    /// <param name="numeroPrimo"></param>
    void Calcular(int numero, int numeroPrimo)
    {
      int resultado = Math.DivRem(numero, numeroPrimo, out int resto);

      if (resto == 0) //Significa que é um divisor
        FatoresPrimos.Add(numeroPrimo);

      if (resto > 0 || numero == resultado) //Decomposição do número chegou no limite, encontrar próximo fator primo
      {
        numeroPrimo = NumererosPrimos.EncontrarProximoNumeroPrimo(numeroPrimo);
        resultado = numero;
      }

      if (resultado != 1) // quando o resultado não for a decomposição não foi finalizada
        Calcular(resultado, numeroPrimo);
    }
    public void Calcular(int numero)
    {
      //Isolando o 1 pq ele é divisor de  qualquer número
      Divisores = new List<int>() { 1 };

      FatoresPrimos = new List<int>();
      
      Calcular(numero, 1);

      MultiplicarFatorSucessivamente();
    }
    /// <summary>
    /// Multiplicando sucessivamente cada fator primo pelos divisores obtivos.
    /// </summary>
    private void MultiplicarFatorSucessivamente()
    {
      foreach (var item in FatoresPrimos)
      {
        int tam = Divisores.Count;
        for (int i = 0; i < tam; i++)
        {
          int result = item * Divisores[i];

          if (!Divisores.Contains(result))//Valores já encontrados, não precisam ser listados.
            Divisores.Add(result);
        }
      }
      Divisores.Sort();
    }

    public override string ToString()
    {
      return $"Números divisores: {string.Join(",", Divisores)}";
    }
  }
}
