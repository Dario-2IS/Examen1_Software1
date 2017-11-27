using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Procesos;

namespace UnitTestCalculo
{
    [TestClass]
    public class UnitTest1
    {

        //PROMEDIO
        [TestMethod]
        public void TestMethodNumeros()
        {
            Calculo calculo = new Calculo();
            double expectedR = 15;
            double actualR;
            actualR = calculo.promedio("15","15","15");
            Assert.AreEqual(expectedR, actualR);
        }


        [TestMethod]
        public void TestMethodLetras()
        {
            Calculo calculo = new Calculo();
            double expectedR = -1;
            double actualR;
            actualR = calculo.promedio("0", "a", "0");
            Assert.AreEqual(expectedR, actualR);
        }


        [TestMethod]
        public void TestMethodNumerosNegativos()
        {
            Calculo calculo = new Calculo();
            double expectedR = -1;
            double actualR;
            actualR = calculo.promedio("-15.8", "-12", "a");
            Assert.AreEqual(expectedR, actualR);
        }

        //ESTADO MATERIA

        [TestMethod]
        public void TestMethodEstadoError()
        {
            Calculo calculo = new Calculo();
            string expectedR = "P";
            string actualR;
            actualR = calculo.estadoMateria("-15.8");
            Assert.AreEqual(expectedR, actualR);
        }

        [TestMethod]
        public void TestMethodEstadoAprobado()
        {
            Calculo calculo = new Calculo();
            string expectedR = "A";
            string actualR;
            actualR = calculo.estadoMateria("18,9");
            Assert.AreEqual(expectedR, actualR);
        }

        [TestMethod]
        public void TestMethodEstadoReprobado()
        {
            Calculo calculo = new Calculo();
            string expectedR = "P";
            string actualR;
            actualR = calculo.estadoMateria("8,9");
            Assert.AreEqual(expectedR, actualR);
        }

        //ESTADO SEMESTER

        [TestMethod]
        public void TestMethodEstadoSemestreAprobado()
        {
            Calculo calculo = new Calculo();
            string expectedR = "Aprobado";
            string actualR;
            actualR = calculo.estadoSemestre("A","A");
            Assert.AreEqual(expectedR, actualR);
        }

    }
}
