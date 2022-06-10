using System;
using System.Collections.Generic;

namespace ChequePorExtenso.Dominio
{
    public class ConversorReais
    {
        private Dictionary<long, string> valores = new Dictionary<long, string>()
        {   {1, "um"},           {2, "dois"},         {3, "três"},
            {4, "quatro"},       {5, "cinco"},        {6, "seis"},         {7, "sete"},
            {8, "oito"},         {9, "nove"},         {10, "dez"},         {11, "onze"},
            {12, "doze"},        {13, "treze"},       {14, "quatorze"},    {15, "quinze"},
            {16, "dezesseis"},   {17, "dezessete"},   {18, "dezoito"},     {19, "dezenove"},
            {20, "vinte"},       {30, "trinta"},      {40, "quarenta"},    {50, "cinquenta"},
            {60, "sessenta"},    {70, "setenta"},     {80, "oitenta"},     {90, "noventa"},
            {100, "cem"},        {200, "duzentos"},   {300, "trezentos"},  {400, "quatrocentos"},
            {500, "quinhentos"}, {600, "seiscentos"}, {700, "setecentos"}, {800, "oitocentos"},
            {900, "novecentos"}
        };

        public string ConverterReais(long valor)
        {
            string resultado = "";

            resultado = Converter(valor);

            resultado += AdicionarSufixoDeReais(valor);

            //return ToUpperPrimeiraLetra(resultado);

            return resultado;
        }

        public string Converter(long valor)
        {
            string resultado = "";

            if (valor < 100)
                resultado += EscreverMenorQueCem(valor);

            else if (valor < 1000)
                resultado += EscreverCentena(valor);
            else if (valor < 1000000)
                resultado += EscreverMil(valor);
            else if (valor < 1000000000)
                resultado += EscreverMilhao(valor);
            else if (valor < 1000000000000)
                resultado += EscreverBilhao(valor);
            return resultado;
        }



        #region Métodos privados
        
        private string EscreverMenorQueCem(long valor)
        {
            string resultado = "";
            if (valor < 20)
                resultado = valores[valor];

            if (valor >= 20 && valor < 100)
            {
                var resto = valor % 10;

                var dezena = valor - resto;

                if (resto == 0)
                    resultado = valores[dezena];
                else
                    resultado = valores[dezena] + " e " + valores[resto];
            }

            return resultado;
        }
        
        private string EscreverCentena(long valor)
        {
            string resultado = "";

            if (valor > 100 && valor < 200)
            {
                resultado = "cento e " + EscreverMenorQueCem(valor - 100);
                return resultado;
            }
            var resto = valor % 100;

            var centena = valor - resto;

            if (resto == 0)
                resultado += valores[centena];
            else
                resultado += valores[centena] + " e " + EscreverMenorQueCem(resto);

            return resultado;
        }

        private string EscreverMil(long valor)
        {
            var resto = valor % 1000;

            var novoValor = valor - resto;

            var valorMilhar = (novoValor / 1000);

            var milhar = Converter(valorMilhar);

            string numeroRestante = "", resultado = "";

            string sufixoMil = AdicionarSufixoMil(resto);

            if (resto != 0)
            {
                numeroRestante = Converter(resto);
                resultado = milhar + sufixoMil + " " + numeroRestante;
            }
            else
                resultado = milhar + sufixoMil;

            return resultado;
        }
        
        private string EscreverMilhao(long valor)
        {
            var resto = valor % 1000000;

            var novoValor = valor - resto;

            var valorMilhao = (novoValor / 1000000);

            var milhao = Converter(valorMilhao);

            string numeroRestante = "", resultado = "";

            string sufixoMilhao = AdicionarSufixoMilhao(valorMilhao);

            if (resto != 0)
            {
                numeroRestante = Converter(resto);
                if (resto <= 1000)
                    resultado = milhao + sufixoMilhao + " e " + numeroRestante;
                else
                    resultado = milhao + sufixoMilhao + " " + numeroRestante;
            }
            else
                resultado = milhao + sufixoMilhao;

            return resultado;
        }

        private string EscreverBilhao(long valor)
        {
            var resto = valor % 1000000000;

            var novoValor = valor - resto;

            var valorBilhao = (novoValor / 1000000000);

            var bilhao = Converter(valorBilhao);

            string numeroRestante = "", resultado = "";

            string sufixoBilhao = AdicionarSufixoBilhao(valorBilhao);

            if (resto != 0)
            {
                numeroRestante = Converter(resto);
                if (resto <= 1000)
                    resultado = bilhao + sufixoBilhao + " e " + numeroRestante;
                else
                    resultado = bilhao + sufixoBilhao + " " + numeroRestante;
            }
            else
                resultado = bilhao + sufixoBilhao;

            return resultado;
        }

        private string AdicionarSufixoMil(long resto)
        {
            if (resto == 0 || resto > 100)
                return " mil";
            else
                return " mil e";
        }

        private string AdicionarSufixoMilhao(long valor)
        {
            if (valor == 1)
                return " milhão";
            else
                return " milhões";
        }

        private string AdicionarSufixoBilhao(long valor)
        {
            if (valor == 1)
                return " bilhão";
            else
                return " bilhões";
        }

        public string ToUpperPrimeiraLetra(string texto)
        {
            var primeiraLetra = texto.ToUpper()[0];
            return primeiraLetra + texto.Substring(1);
        }

        private string AdicionarSufixoDeReais(long numero)
        {
            if (numero == 1)
                return " real";
            else if (numero == 1000000 || numero == 1000000000)
                return " de reais";
            else
                return " reais";
        }

        #endregion

    }
}
