using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var s = Suma.operate(new int[] { 1, 2 });
            Assert.AreEqual(3, s);
        }

        [TestMethod]
        public void TestSumaFail()
        {
            Assert.ThrowsException<InvalidOperationException>(()=> Suma.operate(new int[] { -1, 2 }));
        }

        [TestMethod]
        public void TestDivision()
        {
            Tuple<int, int> datosDivision = Division.operate(4, 2);
            
            Assert.AreEqual(2, datosDivision.Item1);
            Assert.AreEqual(0, datosDivision.Item2);
        }
        
        [TestMethod]
        public void TestDivisionFail()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>Division.operate(-15, -10));
        }

        [TestMethod]
        public void DividirPorCero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.operate(15, 0));
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            var m = Multiplicacion.operate(5, 3);
            Assert.AreEqual(15, m);
        }

        [TestMethod]
        public void TestMultiplicacionFail()
        {
            Assert.ThrowsException<InvalidOperationException>(() => Multiplicacion.operate(-19, 2));
        }

        [TestMethod]
        public void TestResta()
        {
            var r = Resta.operate(10, 2);
            Assert.AreEqual(r, 8);
        }

        [TestMethod]
        public void TestRestaFail()
        {
            Assert.ThrowsException<InvalidOperationException>(()=> Resta.operate(15, -2));
        }
    }
}
