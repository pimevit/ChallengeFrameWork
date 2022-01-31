using AppFramWork.Domain.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppFrameWork.Service
{
  public class Worker : BackgroundService
  {
    private readonly ILogger<Worker> _logger;
    private readonly ICalculoService _service;

    public Worker(ILogger<Worker> logger, ICalculoService calc)
    {
      _logger = logger;
      _service = calc;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      string result;
      while (!stoppingToken.IsCancellationRequested)
      {
        try
        {
          Console.WriteLine("Digite o número que deseja encontrar os divisores");
          result = Console.ReadLine();
          if (int.TryParse(result, out int numero))
          {
            var divisores = _service.ObterDivisoresNumero(numero);
            var primos = _service.ObterNumerosPrimos(divisores);

            _logger.LogInformation($@"
            Resultado{Environment.NewLine}
            Número de Entrada: {numero}{Environment.NewLine}
            Números divisores: {string.Join(", ", divisores)}{Environment.NewLine}
            Números primos: {string.Join(",", primos)}{Environment.NewLine}");

            _logger.LogInformation("Horário {0}:",DateTimeOffset.Now);
          }
          else
            _logger.LogError("O valor digitado não corresponde a um número inteiro {0}", result);
        }
        catch (Exception e)
        {
          _logger.LogError(e.InnerException, "Erro: {0}", e.Message);
        }

        await Task.Delay(1000, stoppingToken);
      }
    }
  }
}
