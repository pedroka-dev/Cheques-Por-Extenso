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
            string valorTxt = valor.ToString();
            string numeroExtenso = "";
            int tamanhoDosDigitos = valorTxt.Length;
            bool ehNumeroReal = valorTxt.Contains(".");

            switch (tamanhoDosDigitos)
            {
                case 1:
                    numeroExtenso += ReceberUnidades(valorTxt);
                    break;
                case 2:
                    numeroExtenso += ReceberDezenas(valorTxt);
                    break;
                case 3:
                    numeroExtenso += ReceberCentena(valorTxt);
                    break;
            }
            
            numeroExtenso += ReceberReal(valorTxt);

            return numeroExtenso;
        }

        private string ReceberCentavos(string numero)
        {
            if(numero == "0.01")
                return " centavo de real";
            else
                return " centavos de real";
        }

        private string ReceberReal(string numero)
        {
            if (numero == "1")
                return " real";
            else
                return " reais";
        }

        private string ReceberUnidades(string numero)
        {
            string texto = "";
            switch (numero)
            {
                case "1":
                    texto = "um";
                    break;
                case "2":
                    texto = "dois";
                    break;
                case "3":
                    texto = "três";
                    break;
                case "4":
                    texto = "quatro";
                    break;
                case "5":
                    texto = "cinco";
                    break;
                case "6":
                    texto = "seis";
                    break;
                case "7":
                    texto = "sete";
                    break;
                case "8":
                    texto = "oito";
                    break;
                case "9":
                    texto = "nove";
                    break;
            }
            return texto;
        }

        private string ReceberDezenas(string numero)
        {
            string texto = "";
            switch (numero)
            {
                case "10":
                    texto = "dez";
                    break;
                case "11":
                    texto = "onze";
                    break;
                case "12":
                    texto = "doze";
                    break;
                case "13":
                    texto = "treze";
                    break;
                case "14":
                    texto = "catorze";
                    break;
                case "15":
                    texto = "quinze";
                    break;
                case "16":
                    texto = "dezesseis";
                    break;
                case "17":
                    texto = "dezessete";
                    break;
                case "18":
                    texto = "dezoito";
                    break;
                case "19":
                    texto = "dezenove";
                    break;
                case "20":
                    texto = "vinte";
                    break;
                case "30":
                    texto = "trinta";
                    break;
                case "40":
                    texto = "quarenta";
                    break;
                case "50":
                    texto = "cinquenta";
                    break;
                case "60":
                    texto = "sessenta";
                    break;
                case "70":
                    texto = "setenta";
                    break;
                case "80":
                    texto = "oitenta";
                    break;
                case "90":
                    texto = "noventa";
                    break;
                default:
                    if (double.Parse(numero) > 0)
                    {
                        texto = ReceberDezenas(numero.Substring(0, 1) + "0") + " e " + ReceberUnidades(numero.Substring(1));
                    }
                    break;
            }
            return texto;
        }

        private string ReceberCentena(string numero)
        {
            string texto = "";
            switch (numero)
            {
                case "100":
                    texto = "cem";
                    break;
                case "200":
                    texto = "duzentos";
                    break;
                case "300":
                    texto = "trezentos";
                    break;
                case "400":
                    texto = "quatrocentos";
                    break;
                case "500":
                    texto = "quinhentos";
                    break;
                case "600":
                    texto = "seiscentos";
                    break;
                case "700":
                    texto = "setescentos";
                    break;
                case "800":
                    texto = "oitoscentos";
                    break;
                case "900":
                    texto = "novescentos";
                    break;
                default:
                    if (double.Parse(numero) > 0)
                    {
                        texto = ReceberCentena(numero.Substring(0, 1) + "00") + " e " + ReceberDezenas(numero.Substring(1));
                    }
                    break;
            }
            return texto;
        }
    }
}
