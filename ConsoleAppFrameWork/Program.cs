using System;
using System.Collections.Generic;

namespace ConsoleAppFrameWork
{
  class Program
  {
    static void Main(string[] args)
    {
      SetTitle();

      var encontrarDivisores = new Divisor();
      int n;

      do
      {
        Reset();
        Console.WriteLine("Informe o numero");

        if (!int.TryParse(Console.ReadLine(), out n))
          Console.WriteLine("O valor informado não corresponde a um número inteiro válido");
        else if (n > 0)
        {
          ImprimirResultado(encontrarDivisores, n);
        }

      } while (n > 0);
    }

    private static void Reset()
    {
      Console.ResetColor();
      Console.WriteLine();
    }

    private static void SetTitle()
    {
      Console.Title = "Desafio Técnico - .NET - Framework";
    }

    private static void ImprimirResultado(Divisor encontrarDivisores, int n)
    {
      LimparTela();

      encontrarDivisores.Calcular(n);
      Console.WriteLine($"Número de Entrada: {n}");
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine(encontrarDivisores.ToString());
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine(NumeroPrimos.ToString(encontrarDivisores.Divisores));
      Console.WriteLine();
    }

    private static void LimparTela()
    {
      Console.Clear();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
