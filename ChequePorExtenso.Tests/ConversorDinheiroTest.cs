using ChequePorExtenso.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChequePorExtenso.Tests
{
    [TestClass]
    public class ConversorDinheiroTest
    {
        [TestMethod]
        [DataRow("8425961637,01", "Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais e um centavo")]
        [DataRow("8425961637,09", "Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais e nove centavos")]
        [DataRow("8425961637,12", "Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais e doze centavos")]
        [DataRow("8425961637,50", "Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais e cinquenta centavos")]
        [DataRow("37,00", "Trinta e sete reais")]
        [DataRow("0,48", "Quarenta e oito centavos de real")]
        [DataRow("0,01", "Um centavo de real")]
        [DataRow("8425961637,48", "Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais e quarenta e oito centavos")]
        public void Deve_Escrever_Oh_Valor_Do_Cheque_Por_Extenso(string valor, string resultadoEsperado)
        {
            ConversorDinheiro conversor = new ConversorDinheiro();

            string resultadoObtido = conversor.EscreverDinheiroPorExtenso(decimal.Parse(valor));

            Assert.AreEqual(resultadoEsperado, resultadoObtido);
        }

    }
}
