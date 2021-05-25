using NUnit.Framework;
using ChequeExtenso.ConsoleApp;

namespace ChequeExtenso.UnitTest
{
    public class ValorPorExtensoTest
    {
        [TestCase]
        public void Deve_RetornarPorExtenso_1Centavo()
        {
            double valor = 0.01;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um centavo de real", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_10Centavos()
        {
            double valor = 0.10;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("dez centavos de real", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_1()
        {
            double valor = 1.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um real", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_10()
        {
            double valor = 10.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("dez reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_100()
        {
            double valor = 100.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("cem reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_1000()
        {
            double valor = 1000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um mil reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_10000()
        {
            double valor = 10000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("dez mil reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_100000()
        {
            double valor = 100000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("cem mil reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_1000000()
        {
            double valor = 1000000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um milhão de reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_10000000()
        {
            double valor = 10000000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("dez milhões de reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_100000000()
        {
            double valor = 100000000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("cem milhões de reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_1000000000()
        {
            double valor = 1000000000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um bilhão de reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_10000000000()
        {
            double valor = 10000000000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("dez bilhões de reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_100000000000()
        {
            double valor = 100000000000.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("cem bilhões de reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_5Centavos()
        {
            double valor = 0.05;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("cinco centavos de real", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_2e25Centavos()
        {
            double valor = 2.25;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("dois reais e vinte e cinco centavos de real", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_7()
        {
            double valor = 7.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_37()
        {
            double valor = 37.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("trinta e sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_637()
        {
            double valor = 637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_1637()
        {
            double valor = 1637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_15415e16Centavos()
        {
            double valor = 15415.16;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("quinze mil quatrocentos e quinze reais e dezesseis centavos de real", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_61637()
        {
            double valor = 61637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_961637()
        {
            double valor = 961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_1852700()
        {
            double valor = 1852700.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um milhão oitocentos e cinquenta e dois mil setecentos reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_5961637()
        {
            double valor = 5961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_25961637()
        {
            double valor = 25961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_425961637()
        {
            double valor = 425961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Deve_RetornarPorExtenso_8425961637()
        {
            double valor = 8425961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }
    }
}