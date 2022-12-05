using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto;

namespace TestProyecto
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Suma_Valores()
        {
            int a = 4;
            int b = 5;
            int c = 9;

            int actual = Calculadora.suma(a, b);

            Assert.AreEqual(c, actual);

        }

        [TestMethod]
        public void Resta_Valores()
        {
            int a = 4;
            int b = 5;
            int c = -1;

            int actual = Calculadora.resta(a, b);

            Assert.AreEqual(c, actual);

        }

        [TestMethod]
        public void Multiplica_Valores()
        {
            int a = 4;
            int b = 5;
            int c = 20;

            int actual = Calculadora.multiplica(a, b);

            Assert.AreEqual(c, actual);

        }

        [TestMethod]
        public void Divide_Valores()
        {
            double a = 12;
            double b = 3;
            double c = 4;

            double actual = Calculadora.divide(a, b);

            Assert.AreEqual(c, actual);

        }

        //Utiliza DataRow
        [DataRow(10, 3, 7)]
        [TestMethod]
        public void Resta_Valores_DataRow(int a, int b, int c)
        {
            int actual = Calculadora.resta(a, b);

            Assert.AreEqual(c, actual);
        }

        //Utiliza DataRow
        [DataRow(10, 3, 30)]
        [TestMethod]
        public void Multiplica_Valores_DataRow(int a, int b, int c)
        {
            int actual = Calculadora.multiplica(a, b);

            Assert.AreEqual(c, actual);
        }
    }
}
