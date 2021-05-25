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
            string numeroExtenso = "";
            string inteiroTxt = valor.ToString();

            string fracaoExtenso = "";
            bool ehNumeroReal = inteiroTxt.Contains(",");
           
            if (ehNumeroReal)
            {
                string fracaoTxt = inteiroTxt.Substring(inteiroTxt.IndexOf(",") + 1);
                inteiroTxt = inteiroTxt.Substring(0, inteiroTxt.IndexOf(","));
                
                if (fracaoTxt.Length < 2 )
                    fracaoTxt += "0";

                fracaoExtenso = ConverteNumerosInteiros(fracaoTxt.TrimStart('0'));
                fracaoExtenso += ReceberCentavos(fracaoTxt);
            }

            numeroExtenso += ConverteNumerosInteiros(inteiroTxt);
            if(ehNumeroReal && inteiroTxt != "0")
                numeroExtenso += ReceberMoeda(inteiroTxt) +" e ";
            numeroExtenso += fracaoExtenso;

            if (ehNumeroReal || numeroExtenso.EndsWith("milhão ") || numeroExtenso.EndsWith("milhões ") || numeroExtenso.EndsWith("bilhão ") || numeroExtenso.EndsWith("bilhões "))
                numeroExtenso += "de ";

            if(!ehNumeroReal)
                numeroExtenso += ReceberMoeda(inteiroTxt);
            else
                numeroExtenso += ReceberMoeda("0");

            return numeroExtenso ;
        }

        private string ConverteNumerosInteiros(string numero)
        {
            int numeroDeDigitos = numero.Length;
            int posicaoMilhar = 0;
            string casaMilhar = "";
            bool ehSomenteZeros = string.IsNullOrEmpty(numero.Trim('0'));

            if(!ehSomenteZeros)
            {
                switch (numeroDeDigitos)
                {
                    case 1:
                        return ReceberUnidades(numero);

                    case 2:
                        return ReceberDezenas(numero);

                    case 3:
                        return ReceberCentena(numero);

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
                            casaMilhar = "bilhões ";
                        break;
                }

                return ConverteNumerosInteiros(numero.Substring(0, posicaoMilhar)) + casaMilhar + ConverteNumerosInteiros(numero.Substring(posicaoMilhar));
            }
            return "";
        }
            
        private string ReceberCentavos(string numero)
        {
            if(numero == "01")
                return "centavo ";
            else
                return "centavos ";
        }

        private string ReceberMoeda(string numero)
        {
            if (numero == "1" || numero == "0")
                return "real";
            else
                return "reais";
        }

        private string ReceberUnidades(string numero)
        {
            switch (numero)
            {
                case "1":
                    return "um ";
                case "2":
                    return "dois ";
                case "3":
                    return "três ";
                case "4":
                    return "quatro ";
                case "5":
                    return "cinco ";
                case "6":
                    return "seis ";
                case "7":
                    return "sete ";
                case "8":
                    return "oito ";
                case "9":
                    return "nove ";
                default:
                    return "";
            }
        }

        private string ReceberDezenas(string numero)
        {
            switch (numero)
            {
                case "10":
                    return "dez ";
                case "11":
                    return "onze ";
                case "12":
                    return "doze ";
                case "13":
                    return "treze ";
                case "14":
                    return "catorze ";
                case "15":
                    return "quinze ";
                case "16":
                    return "dezesseis ";                 
                case "17":
                    return "dezessete ";
                case "18":
                    return "dezoito ";
                case "19":
                    return "dezenove ";
                case "20":
                    return "vinte ";
                case "30":
                    return "trinta ";
                case "40":
                    return "quarenta ";
                case "50":
                    return "cinquenta ";
                case "60":
                    return "sessenta ";
                case "70":
                    return "setenta ";
                case "80":
                    return "oitenta ";
                case "90":
                    return "noventa ";

                default:
                    if (double.Parse(numero) > 0)
                    {
                        return ReceberDezenas(numero.Substring(0, 1) + "0") + "e " + ReceberUnidades(numero.Substring(1));
                    }
                    return "";
            }
        }

        private string ReceberCentena(string numero)
        {
            switch (numero)
            {
                case "100":
                    return "cem ";
                case "200":
                    return "duzentos ";
                case "300":
                    return "trezentos ";
                case "400":
                    return "quatrocentos ";
                case "500":
                    return "quinhentos ";
                case "600":
                    return "seiscentos ";
                case "700":
                    return "setecentos ";
                case "800":
                    return "oitocentos ";
                case "900":
                    return "novecentos ";

                default:
                    if (double.Parse(numero) > 0)
                    {
                        return ReceberCentena(numero.Substring(0, 1) + "00") + "e " + ReceberDezenas(numero.Substring(1));
                    }
                    return "";
            }
        }
    }
}
