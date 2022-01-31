using AppFramWork.Domain.Entities;
using AppFramWork.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrameWork.Application
{
  public class CalculoService : ICalculoService
  {
    public bool IdentificarNumeroPrimo(int numero)
    {
      if (numero <= 1)
        throw new ArgumentException("Um número é classificado como primo se ele é maior do que o numeral 1, e é divisível apenas por um e por ele mesmo.");

      return new NumeroPrimo().IdentificarNumeroPrimo(numero);

    }

    public List<int> ObterDivisoresNumero(int numero)
    {
      if (numero == 0)
        throw new DivideByZeroException();

      var retorno = new Divisor();
      retorno.Calcular(numero);
      
      return retorno.Divisores;
    }

    public List<int> ObterNumerosPrimos(List<int> numeros)
    {
      if (numeros?.Count == 0)
        throw new ArgumentOutOfRangeException("Lista vázia");

      return new NumeroPrimo().ObterNumerosPrimos(numeros);
    }
  }
}
