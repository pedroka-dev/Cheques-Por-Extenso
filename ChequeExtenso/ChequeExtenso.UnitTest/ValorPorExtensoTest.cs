using NUnit.Framework;
using ChequeExtenso.ConsoleApp;

namespace ChequeExtenso.UnitTest
{
    public class ValorPorExtensoTest
    {
        [TestCase]
        public void Test1()
        {
            double valor = 0.05;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("cinco centavos de real", resultado);
        }

        [TestCase]
        public void Test2()
        {
            double valor = 2.25;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("dois reais e vinte e cinco centavos de real", resultado);
        }

        [TestCase]
        public void Test3()
        {
            double valor = 7.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("sete reais", resultado);
        }

        [TestCase]
        public void Test4()
        {
            double valor = 37.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("trinta e sete reais", resultado);
        }

        [TestCase]
        public void Test5()
        {
            double valor = 637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Test6()
        {
            double valor = 1637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Test7()
        {
            double valor = 15415.16;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("quinze mil quatrocentos e quinze reais e dezesseis centavos", resultado);
        }

        [TestCase]
        public void Test9()
        {
            double valor = 61637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Test10()
        {
            double valor = 961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Test11()
        {
            double valor = 1852700.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("um milhão oitocentos e cinquenta e dois mil e setecentos reais", resultado);
        }

        [TestCase]
        public void Test12()
        {
            double valor = 5961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Test13()
        {
            double valor = 25961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Test14()
        {
            double valor = 425961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }

        [TestCase]
        public void Test15()
        {
            double valor = 8425961637.00;
            string moeda = "brl";

            ValorPorExtenso valorPorExtenso = new ValorPorExtenso(valor, moeda);
            string resultado = valorPorExtenso.ConverterParaExtenso();

            Assert.AreEqual("oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", resultado);
        }
    }
}