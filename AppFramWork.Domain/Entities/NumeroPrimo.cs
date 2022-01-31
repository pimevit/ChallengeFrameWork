using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFramWork.Domain.Entities
{
  public class NumeroPrimo
  {
    public int EncontrarProximoNumeroPrimo(int num)
    {
      int retorno = 0;
      do
      {
        num++;
        if (IdentificarNumeroPrimo(num))
          retorno = num;

      } while (retorno == 0);
      return retorno;
    }

    public bool IdentificarNumeroPrimo(int numero)
    {
      //aplicando a regra de divisibilidade
      // a regra de divisibilidade é aplicada de maneira analogica verificando a disponibilidade
      int divisores = 2;
      bool retorno;
      do
      {
        if (retorno = numero == divisores)
          break;
        else if (retorno = (!(numero % 2 == 0) && !(numero % 3 == 0) && !(numero % 5 == 0) && !(numero % 7 == 0)))
          break;
        if (divisores % 2 == 0)
          divisores++;
        else
          divisores += 2;
      } while (divisores < 8);

      return retorno;
    }

    public List<int> ObterNumerosPrimos(List<int> numeros)
    {
      List<int> primos = new List<int>();
      numeros.ForEach(x => { if (IdentificarNumeroPrimo(x)) primos.Add(x); });
      return primos;
    }

    public string ToString(List<int> numeros)
    {
      return $"Divisores primos:{string.Join(",", ObterNumerosPrimos(numeros))}";
    }
  }
}