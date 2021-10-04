using System;
using SoftFinance.Api.Models;

namespace SoftFinance.Api.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        public ServiceResponse<string> CalcularJuros(decimal valorInicial, int tempo)
        {
            return new ServiceResponse<string>() { Data = new TaxaJuros().CalculaJuros(valorInicial, tempo).ToString("f"), Success = true };
        }
    }
}