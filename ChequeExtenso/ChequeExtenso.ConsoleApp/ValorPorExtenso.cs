using System;
using System.Collections.Generic;
using System.Text;

namespace ChequeExtenso.ConsoleApp
{
    public class ValorPorExtenso
    {
        private double valor;
        private string moeda;

        public ValorPorExtenso(double valor, string moeda)
        {
            this.valor = valor;
            this.moeda = moeda;
        }

        public string ConverterParaExtenso()
        {
            throw new NotImplementedException();
        }
    }
}
