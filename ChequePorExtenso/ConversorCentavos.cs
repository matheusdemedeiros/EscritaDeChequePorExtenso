using System;
using System.Collections.Generic;

namespace ChequePorExtenso
{
    public class ConversorCentavos
    {
        private Dictionary<int, string> valores = new Dictionary<int, string>()
        {   {1, "um"},           {2, "dois"},         {3, "três"},
            {4, "quatro"},       {5, "cinco"},        {6, "seis"},         {7, "sete"},
            {8, "oito"},         {9, "nove"},         {10, "dez"},         {11, "onze"},
            {12, "doze"},        {13, "treze"},       {14, "quatorze"},    {15, "quinze"},
            {16, "dezesseis"},   {17, "dezessete"},   {18, "dezoito"},     {19, "dezenove"},
            {20, "vinte"},       {30, "trinta"},      {40, "quarenta"},    {50, "cinquenta"},
            {60, "sessenta"},    {70, "setenta"},     {80, "oitenta"},     {90, "noventa"}
        };

        public string ConverterCentavos(double valor)
        {
            var numeroInteiro = (int)(valor * 100);

            string resultado = "";

            if (numeroInteiro <= 20)
                resultado = valores[numeroInteiro];

            if (numeroInteiro > 20)
            {
                var resto = numeroInteiro % 10;
                var dezena = numeroInteiro - resto;

                if (resto == 0)
                {
                    resultado = valores[numeroInteiro];
                }
                else
                    resultado = valores[dezena] + " e " + valores[resto];
            }

            resultado += AdicionarSufixoDeCentavos(numeroInteiro);

            return ToUpperPrimeiraLetra(resultado);
        }

        #region Métodos privados

        private string AdicionarSufixoDeCentavos(int numeroInteiro)
        {
            return numeroInteiro > 1 ? " centavos de real" : " centavo de real";
        }

        public string ToUpperPrimeiraLetra(string texto)
        {
            var primeiraLetra = texto.ToUpper()[0];
            return primeiraLetra + texto.Substring(1);
        }

        #endregion
    }
}
