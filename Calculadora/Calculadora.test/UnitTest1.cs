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
            var s = Suma.sum(new int[] { 1, 2 });
            Assert.AreEqual(3, s);
        }

        [TestMethod]
        public void TestSumaFail()
        {
            Assert.ThrowsException<InvalidOperationException>(()=> Suma.sum(new int[] { -1, 2 }));
        }

        [TestMethod]
        public void TestDivision()
        {
            DatosDivision datosDivision = Division.division(4, 2);
            
            Assert.AreEqual(2, datosDivision.resultado);
            Assert.AreEqual(0, datosDivision.resto);
        }
    }
}
