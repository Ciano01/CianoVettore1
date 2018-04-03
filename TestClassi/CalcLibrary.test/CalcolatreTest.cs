using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLibrary;

namespace CalcLibrary.test
{
    [TestClass]
    public class CalcolatreTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] v1 = new int[] { 11, 22, 13, 4 };
            int[] v2 = new int[] { 4,11,13,22 };
            int[] vettoreOrdinato = Calcolatrice.Ordina(v1);
            CollectionAssert.AreEqual(v2, vettoreOrdinato);

        }
    }
}