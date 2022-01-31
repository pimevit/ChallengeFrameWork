using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFrameWork
{
  [Obsolete("Utilizar Classe migrada - AppFramWork.Domain.Entities.Divisor")]
  public class Divisor
  {
    protected List<int> FatoresPrimos { get; set; }
    public List<int> Divisores { protected set; get; }
    void Calcular(int numero, int numeroPrimo)
    {
      int resultado = Math.DivRem(numero, numeroPrimo, out int resto);

      if (resto == 0)
        FatoresPrimos.Add(numeroPrimo);

      if (resto > 0 || numero == resultado)
      {
        numeroPrimo = NumeroPrimos.EncontrarProximoNumeroPrimo(numeroPrimo);
        resultado = numero;
      }

      if (resultado != 1)
        Calcular(resultado, numeroPrimo);
    }
    public void Calcular(int numero)
    {
      Divisores = new() { 1 };
      FatoresPrimos = new();
      Calcular(numero, 1);

      MultiplicarFatorSucessivamente();
    }

    private void MultiplicarFatorSucessivamente()
    {
      foreach (var item in FatoresPrimos)
      {
        int tam = Divisores.Count;
        for (int i = 0; i < tam; i++)
        {
          int result = item * Divisores[i];
          if (!Divisores.Contains(result))
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
