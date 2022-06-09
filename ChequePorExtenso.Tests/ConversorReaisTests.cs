using ChequePorExtenso.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChequePorExtenso.Tests
{

    [TestClass]
    public class ConversorReaisTests
    {

        [TestMethod]
        [DataRow(1, "Um real")]
        public void Deve_Converter_1_Real(int valor, string resultadoEsperado)
        {
            ConversorReais cv = new ConversorReais();

            var resultado = cv.ConverterReais(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        [DataRow(2, "Dois reais")]
        [DataRow(3, "Três reais")]
        [DataRow(4, "Quatro reais")]
        [DataRow(5, "Cinco reais")]
        [DataRow(6, "Seis reais")]
        [DataRow(7, "Sete reais")]
        [DataRow(8, "Oito reais")]
        [DataRow(9, "Nove reais")]
        [DataRow(10, "Dez reais")]
        public void Deve_Converter_Do_2_Ate_19_Reais(int valor, string resultadoEsperado)
        {
            ConversorReais cv = new ConversorReais();

            var resultado = cv.ConverterReais(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(11, "Onze reais")]
        [DataRow(12, "Doze reais")]
        [DataRow(13, "Treze reais")]
        [DataRow(14, "Quatorze reais")]
        [DataRow(15, "Quinze reais")]
        [DataRow(16, "Dezesseis reais")]
        [DataRow(17, "Dezessete reais")]
        [DataRow(18, "Dezoito reais")]
        [DataRow(19, "Dezenove reais")]
        [DataRow(20, "Vinte reais")]
        public void Deve_Converter_Do_11_Ate_19_Reais(int valor, string resultadoEsperado)
        {
            ConversorReais cv = new ConversorReais();

            var resultado = cv.ConverterReais(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        [DataRow(20, "Vinte reais")]
        [DataRow(30, "Trinta reais")]
        [DataRow(40, "Quarenta reais")]
        [DataRow(50, "Cinquenta reais")]
        [DataRow(60, "Sessenta reais")]
        [DataRow(70, "Setenta reais")]
        [DataRow(80, "Oitenta reais")]
        [DataRow(90, "Noventa reais")]
        public void Deve_Converter_Dezenas_Inteiras_Dee_Reais(int valor, string resultadoEsperado)
        {
            ConversorReais cv = new ConversorReais();

            var resultado = cv.ConverterReais(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(21, "Vinte e um reais")]
        [DataRow(32, "Trinta e dois reais")]
        [DataRow(43, "Quarenta e três reais")]
        [DataRow(54, "Cinquenta e quatro reais")]
        [DataRow(65, "Sessenta e cinco reais")]
        [DataRow(76, "Setenta e seis reais")]
        [DataRow(87, "Oitenta e sete reais")]
        [DataRow(98, "Noventa e oito reais")]
        [DataRow(99, "Noventa e nove reais")]
        public void Deve_Converter_Dezenas_E_Unidades_De_Reais(int valor, string resultadoEsperado)
        {
            ConversorReais cv = new ConversorReais();

            var resultado = cv.ConverterReais(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        [DataRow(100, "Cem reais")]
        [DataRow(200, "Duzentos reais")]
        [DataRow(300, "Trezentos reais")]
        [DataRow(400, "Quatrocentos reais")]
        [DataRow(500, "Quinhentos reais")]
        [DataRow(600, "Seiscentos reais")]
        [DataRow(700, "Setecentos reais")]
        [DataRow(800, "Oitocentos reais")]
        [DataRow(900, "Novecentos reais")]
        public void Deve_Converter_Centenas_Inteiras_De_Reais(int valor, string resultadoEsperado)
        {
            ConversorReais cv = new ConversorReais();

            var resultado = cv.ConverterReais(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(101, "Cento e um reais")]
        [DataRow(111, "Cento e onze reais")]
        [DataRow(120, "Cento e vinte reais")]
        [DataRow(132, "Cento e trinta e dois reais")]
        [DataRow(143, "Cento e quarenta e três reais")]
        [DataRow(154, "Cento e cinquenta e quatro reais")]
        [DataRow(165, "Cento e sessenta e cinco reais")]
        [DataRow(176, "Cento e setenta e seis reais")]
        [DataRow(187, "Cento e oitenta e sete reais")]
        [DataRow(180, "Cento e oitenta reais")]
        [DataRow(110, "Cento e dez reais")]
        [DataRow(190, "Cento e noventa reais")]
        public void Deve_Converter_De_Cem_Ate_Duzentos_Reais(int valor, string resultadoEsperado)
        {
            ConversorReais cv = new ConversorReais();

            var resultado = cv.ConverterReais(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }





    }
}
