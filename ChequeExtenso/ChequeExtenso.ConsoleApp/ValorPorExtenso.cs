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

            //Conversao de numeros quebrados que nao funciona
            //if (ehNumeroReal)
            //{
            //    numeroFracao = valorTxt.Substring(valorTxt.IndexOf(".")).TrimStart('0').Trim('.');
            //}

            //numeroExtenso += ReceberDeZeroAteCem(valorTxt);

            //if (ehNumeroReal)
            //{
            //    string centavosExtenso = ReceberDeZeroAteCem(numeroFracao);

            //    if (valorTxt.StartsWith("0"))
            //        numeroExtenso += centavosExtenso + ReceberCentavos(centavosExtenso);
            //}
            //else
            //{
            //    numeroExtenso += ReceberReal(valorTxt);
            //}
            numeroExtenso += ConverteNumerosInteiros(valorTxt);

            numeroExtenso += ReceberReal(valorTxt);

            return numeroExtenso;
        }

        private string ConverteNumerosInteiros(string numero)
        {
            string inteiroExtenso = "";
            bool estaPronto = false;
            int numeroDeDigitos = numero.Length;
            int posicaoMilhar = 0;
            string casaMilhar = "";

            switch (numeroDeDigitos)
            {
                case 1:
                    inteiroExtenso = ReceberUnidades(numero);
                    estaPronto = true;
                    break;

                case 2:
                    inteiroExtenso = ReceberDezenas(numero);
                    estaPronto = true;
                    break;

                case 3:
                    inteiroExtenso = ReceberCentena(numero);
                    estaPronto = true;
                    break;

                case 4:
                case 5:
                case 6:
                    posicaoMilhar = (numeroDeDigitos % 4) + 1;
                    casaMilhar = "mil ";
                    break;

                case 7:
                case 8:
                case 9:
                    posicaoMilhar = (numeroDeDigitos % 7) + 1;
                    if (numeroDeDigitos == 7 && numero.StartsWith("1"))
                        casaMilhar = "milhão ";
                    else
                        casaMilhar = "milhões ";
                    break;

                case 10:
                case 11:
                case 12:
                    posicaoMilhar = (numeroDeDigitos % 10) + 1;
                    if (numeroDeDigitos == 10 && numero.StartsWith("1"))
                        casaMilhar = "bilhão ";
                    else
                        casaMilhar = "bilhôes ";
                    break;

                default:
                    estaPronto = true;
                    break;
            }

            if (!estaPronto)
            {
                if (!string.IsNullOrEmpty(numero.Trim('0')))
                    inteiroExtenso = ConverteNumerosInteiros(numero.Substring(0, posicaoMilhar)) + casaMilhar + ConverteNumerosInteiros(numero.Substring(posicaoMilhar));
                else
                    inteiroExtenso = ConverteNumerosInteiros(numero.Substring(0, posicaoMilhar)) + ConverteNumerosInteiros(numero.Substring(posicaoMilhar));
            }
            return inteiroExtenso;
        }
            
        private string ReceberCentavos(string numero)
        {
            if(numero == "0.01")
                return "centavo de real";
            else
                return "centavos de real";
        }

        private string ReceberReal(string numero)
        {
            if (numero == "1")
                return "real";
            else
                return "reais";
        }

        private string ReceberUnidades(string numero)
        {
            string texto = "";
            switch (numero)
            {
                case "1":
                    texto = "um ";
                    break;
                case "2":
                    texto = "dois ";
                    break;
                case "3":
                    texto = "três ";
                    break;
                case "4":
                    texto = "quatro ";
                    break;
                case "5":
                    texto = "cinco ";
                    break;
                case "6":
                    texto = "seis ";
                    break;
                case "7":
                    texto = "sete ";
                    break;
                case "8":
                    texto = "oito ";
                    break;
                case "9":
                    texto = "nove ";
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
                    texto = "dez ";
                    break;
                case "11":
                    texto = "onze ";
                    break;
                case "12":
                    texto = "doze ";
                    break;
                case "13":
                    texto = "treze ";
                    break;
                case "14":
                    texto = "catorze ";
                    break;
                case "15":
                    texto = "quinze ";
                    break;
                case "16":
                    texto = "dezesseis ";
                    break;
                case "17":
                    texto = "dezessete ";
                    break;
                case "18":
                    texto = "dezoito ";
                    break;
                case "19":
                    texto = "dezenove ";
                    break;
                case "20":
                    texto = "vinte ";
                    break;
                case "30":
                    texto = "trinta ";
                    break;
                case "40":
                    texto = "quarenta ";
                    break;
                case "50":
                    texto = "cinquenta ";
                    break;
                case "60":
                    texto = "sessenta ";
                    break;
                case "70":
                    texto = "setenta ";
                    break;
                case "80":
                    texto = "oitenta ";
                    break;
                case "90":
                    texto = "noventa ";
                    break;
                default:
                    if (double.Parse(numero) > 0)
                    {
                        texto = ReceberDezenas(numero.Substring(0, 1) + "0") + "e " + ReceberUnidades(numero.Substring(1));
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
                    texto = "cem ";
                    break;
                case "200":
                    texto = "duzentos ";
                    break;
                case "300":
                    texto = "trezentos ";
                    break;
                case "400":
                    texto = "quatrocentos ";
                    break;
                case "500":
                    texto = "quinhentos ";
                    break;
                case "600":
                    texto = "seiscentos ";
                    break;
                case "700":
                    texto = "setecentos ";
                    break;
                case "800":
                    texto = "oitocentos ";
                    break;
                case "900":
                    texto = "novecentos ";
                    break;
                default:
                    if (double.Parse(numero) > 0)
                    {
                        texto = ReceberCentena(numero.Substring(0, 1) + "00") + "e " + ReceberDezenas(numero.Substring(1));
                    }
                    break;
            }
            return texto;
        }
    }
}
