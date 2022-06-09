using System.Collections.Generic;

namespace ChequePorExtenso.Dominio
{
    public class ConversorReais
    {
        private Dictionary<int, string> valores = new Dictionary<int, string>()
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

        public string ConverterReais(int valor)
        {
            string resultado = "";

            if (valor < 100)
                resultado += ConverterMenorQueCem(valor);
            
            else if (valor < 1000)
                resultado += ConverterEntreCemEhMil(valor);
            
            else if (valor < 10000)
                //resultado += Converter(valor);



            resultado += AdicionarSufixoDeReais(valor);

            return ToUpperPrimeiraLetra(resultado);
        }


        #region Métodos privados

        private string ConverterMenorQueCem(int valor)
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

        private string ConverterEntreCemEhMil(int valor)
        {
            string resultado = "";

            if (valor > 100 && valor < 200)
            {
                resultado = "cento e " + ConverterMenorQueCem(valor - 100);
                return resultado;
            }
            var resto = valor % 100;

            var centena = valor - resto;

            if (resto == 0)
                resultado += valores[centena];
            else
                resultado += valores[centena] + " e " + ConverterMenorQueCem(resto);

            return resultado;
        }

        public string ToUpperPrimeiraLetra(string texto)
        {
            var primeiraLetra = texto.ToUpper()[0];
            return primeiraLetra + texto.Substring(1);
        }

        private string AdicionarSufixoDeReais(int numero)
        {
            return numero > 1 ? " reais" : " real";
        }

        #endregion

    }
}
