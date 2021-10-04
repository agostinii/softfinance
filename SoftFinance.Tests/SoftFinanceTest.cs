using Moq;
using SoftFinance.Api.Controllers;
using SoftFinance.Api.Models;
using SoftFinance.Api.Services;
using Xunit;

namespace SoftFinance.Tests
{
    public class SoftFinanceTest
    {
        private TaxaJurosService _taxaJurosService;
        private CalculaJurosService _calculaJurosService;

        public SoftFinanceTest()
        {
            _taxaJurosService = new TaxaJurosService();
            _calculaJurosService = new CalculaJurosService();
        }

        [Fact]
        public void ObterTaxaJuros()
        {
            var result = _taxaJurosService.Get();
            Assert.True(result.Success && result.Data == 0.01);
        }

        [Fact]
        public void CalcularJuros()
        {
            var valorInicial = 100;
            var tempo = 5;
            var result = _calculaJurosService.CalcularJuros(valorInicial, tempo);
            Assert.True(result.Success && result.Data == "105,10");
        }

        [Fact]
        public void ShowMeTheCode()
        {
            var mockService = new Mock<ICalculaJurosService>();
            var calculaJuroscontroller = new CalculaJurosController(mockService.Object);
            var result = calculaJuroscontroller.ShowMeTheCode();
            Assert.True(result == "https://www.google.com");
        }
    }
}
