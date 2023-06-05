using System;

namespace ChequePorExtenso.Dominio
{
    public class ConversorDinheiro
    {
        private ConversorCentavos cc;
        private ConversorReais cr;

        public ConversorDinheiro()
        {
            cc = new ConversorCentavos();
            cr = new ConversorReais();
        }

        public string EscreverDinheiroPorExtenso(decimal valor)
        {
            string resultado = "";

            if (valor <= 0)
                return "Valor inválido";

            long valorReais = (long)Math.Truncate(valor);

            decimal valorCentavos = (decimal)(valor - valorReais);

            if (valorCentavos < 0)
                valorCentavos = valorCentavos * (-1);


            string reais = "", centavos = "";
            if (valorReais > 0)
                reais = cr.ConverterReais(valorReais);

            if (valorCentavos > 0)
                centavos = cc.ConverterCentavos(valorCentavos);

            resultado = reais;

            if (string.IsNullOrEmpty(centavos) == false)
            {
                if (string.IsNullOrEmpty(resultado))
                    resultado = centavos;
                else
                    resultado += " e " + RemoverSufixoReaisDosCentavos(centavos);
            }

            return ToUpperPrimeiraLetra(resultado);
        }

        public string ToUpperPrimeiraLetra(string texto)
        {
            var primeiraLetra = texto.ToUpper()[0];
            return primeiraLetra + texto.Substring(1);
        }

        private string RemoverSufixoReaisDosCentavos(string texto)
        {
            var retorno = texto.Replace(" de real", "");
            return retorno;
        }
    }
}
