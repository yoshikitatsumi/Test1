using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test1;

namespace UnitTestProject7
{
    [TestClass]
    public class UnitTest1
    {
        CalculatorClass2 CalcClass2 = new CalculatorClass2();

        [TestMethod]
        public void TestMethod1()
        {
            int z = CalcClass2.Add(4, 5);
            Assert.AreEqual(z, 9);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int z = CalcClass2.Sub(10, 5);
            Assert.AreNotEqual(z, 9);

        }
        [TestMethod]
        public void TestMethod3()
        {
            int z = CalcClass2.Multi(2, 5);
            Assert.AreEqual(z, 10);

        }
    }
}
