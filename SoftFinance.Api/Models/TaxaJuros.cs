using System;

namespace SoftFinance.Api.Models
{
    public class TaxaJuros
    {
        public double Taxa => 0.01;

        public decimal CalculaJuros(decimal valorInicial, int tempo) => valorInicial * (decimal)Math.Pow(Taxa + 1, tempo);
    }
}