using SoftFinance.Api.Models;

namespace SoftFinance.Api.Services
{
    public interface ICalculaJurosService
     {
          ServiceResponse<string> CalcularJuros(decimal valorInicial, int tempo);
     }
}