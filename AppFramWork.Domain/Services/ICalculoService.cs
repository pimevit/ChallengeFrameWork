using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFramWork.Domain.Services
{
  public interface ICalculoService
  {
  /// <summary>
  /// Obter divisores de um número
  /// </summary>
  /// <param name="numero"></param>
  /// <returns>Um lista contendo os divisores do número</returns>
    List<int> ObterDivisoresNumero(int numero);
    
    /// <summary>
    /// Identificar os números primos contidos na lista informada 
    /// </summary>
    /// <param name="numeros"></param>
    /// <returns>Uma lista contendo o números primos existentes na lista informada</returns>
    List<int> ObterNumerosPrimos(List<int> numeros);
    
    /// <summary>
    /// Indentifica se o numero informado é primo 
    /// </summary>
    /// <param name="numero"></param>
    /// <returns>true - Para números primos</returns>
    bool IdentificarNumeroPrimo(int numero);
  }
}
