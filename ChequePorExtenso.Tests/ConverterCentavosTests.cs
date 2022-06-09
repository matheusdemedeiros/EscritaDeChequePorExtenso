using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChequePorExtenso.Tests
{
    [TestClass]
    public class ConverterCentavosTests
    {
        [TestMethod]
        [DataRow(0.01, "Um centavo de real")]
        public void Deve_Converter_1_Centavo(double valor, string resultadoEsperado)
        {
            ConversorCentavos cv = new ConversorCentavos();
            
            var resultado = cv.ConverterCentavos(valor);
          
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(0.02, "Dois centavos de real")]
        [DataRow(0.03, "Três centavos de real")]
        [DataRow(0.04, "Quatro centavos de real")]
        [DataRow(0.05, "Cinco centavos de real")]
        [DataRow(0.06, "Seis centavos de real")]
        [DataRow(0.07, "Sete centavos de real")]
        [DataRow(0.08, "Oito centavos de real")]
        [DataRow(0.09, "Nove centavos de real")]
        [DataRow(0.10, "Dez centavos de real")]
        public void Deve_Converter_Do_2_Ate_19_Centavo(double valor, string resultadoEsperado)
        {
            ConversorCentavos cv = new ConversorCentavos();

            var resultado = cv.ConverterCentavos(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(0.11, "Onze centavos de real")]
        [DataRow(0.12, "Doze centavos de real")]
        [DataRow(0.13, "Treze centavos de real")]
        [DataRow(0.14, "Quatorze centavos de real")]
        [DataRow(0.15, "Quinze centavos de real")]
        [DataRow(0.16, "Dezesseis centavos de real")]
        [DataRow(0.17, "Dezessete centavos de real")]
        [DataRow(0.18, "Dezoito centavos de real")]
        [DataRow(0.19, "Dezenove centavos de real")]
        [DataRow(0.20, "Vinte centavos de real")]
        public void Deve_Converter_Do_11_Ate_19_Centavo(double valor, string resultadoEsperado)
        {
            ConversorCentavos cv = new ConversorCentavos();

            var resultado = cv.ConverterCentavos(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(0.10, "Dez centavos de real")]
        [DataRow(0.20, "Vinte centavos de real")]
        [DataRow(0.30, "Trinta centavos de real")]
        [DataRow(0.40, "Quarenta centavos de real")]
        [DataRow(0.50, "Cinquenta centavos de real")]
        [DataRow(0.60, "Sessenta centavos de real")]
        [DataRow(0.70, "Setenta centavos de real")]
        [DataRow(0.80, "Oitenta centavos de real")]
        [DataRow(0.90, "Noventa centavos de real")]
        public void Deve_Converter_Dezenas_Inteiras_De_Centavo(double valor, string resultadoEsperado)
        {
            ConversorCentavos cv = new ConversorCentavos();

            var resultado = cv.ConverterCentavos(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        
        [TestMethod]
        [DataRow(0.21, "Vinte e um centavos de real")]
        [DataRow(0.32, "Trinta e dois centavos de real")]
        [DataRow(0.43, "Quarenta e três centavos de real")]
        [DataRow(0.54, "Cinquenta e quatro centavos de real")]
        [DataRow(0.65, "Sessenta e cinco centavos de real")]
        [DataRow(0.76, "Setenta e seis centavos de real")]
        [DataRow(0.87, "Oitenta e sete centavos de real")]
        [DataRow(0.98, "Noventa e oito centavos de real")]
        [DataRow(0.99, "Noventa e nove centavos de real")]
        public void Deve_Converter_Dezenas_E_Unidades_De_Centavo(double valor, string resultadoEsperado)
        {
            ConversorCentavos cv = new ConversorCentavos();

            var resultado = cv.ConverterCentavos(valor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
