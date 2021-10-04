using SoftFinance.Api.Models;

namespace SoftFinance.Api.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public ServiceResponse<double> Get()
        {
            return new ServiceResponse<double>() { Data = new TaxaJuros().Taxa, Success = true };
        }
    }
}