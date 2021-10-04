using SoftFinance.Api.Models;

namespace SoftFinance.Api.Services
{
    public interface ITaxaJurosService
     {
          ServiceResponse<double> Get();
     }
}