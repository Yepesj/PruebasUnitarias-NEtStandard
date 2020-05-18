using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaNegocioTest
{
    [TestClass]
    public class EnvioTest
    {
        [TestMethod]
        public void TestCalcularPrecioTotalRonAniejo()
        {
            int precioEsperado = 160000;
            int precioLogicaNegocio = Envio.CalcularVentaDeLicores(1, 1, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularPrecioTotalRon()
        {
            int precioEsperado = 65000;
            int precioLogicaNegocio = Envio.CalcularVentaDeLicores(1, 1, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularPrecioTotalVodkaaniejo()
        {
            int precioEsperado = 84000;
            int precioLogicaNegocio = Envio.CalcularVentaDeLicores(1,2, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularPrecioTotalVodka()
        {
            int precioEsperado = 120000;
            int precioLogicaNegocio = Envio.CalcularVentaDeLicores(2, 2, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularPrecioTotalWhiskeyAniejo()
        {
            int precioEsperado = 136000;
            int precioLogicaNegocio = Envio.CalcularVentaDeLicores(2, 3, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }
        [TestMethod]
        public void TestCalcularPrecioTotalWhiskey()
        {
            int precioEsperado = 200000;
            int precioLogicaNegocio = Envio.CalcularVentaDeLicores(4, 3, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }
        [TestMethod]
        public void TestCalcularPrecioTotalGinebraAniejo()
        {
            int precioEsperado = 200000;
            int precioLogicaNegocio = Envio.CalcularVentaDeLicores(1, 4, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }
        [TestMethod]
        public void TestCalcularPrecioTotalGinebra()
        {
            int precioEsperado = 160000;
            int precioLogicaNegocio = Envio.CalcularVentaDeLicores(1, 4, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

    }
}
