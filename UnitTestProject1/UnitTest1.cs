using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcNoBtn;

namespace WindowsFormsCalc2 //.Form1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(1, 2, '+', 3)]
        [DataRow(1, 2, '*', 2)]
        [DataRow(1, 2, '-', -1)]
        [DataRow(2, 2, '/', 1)]

        [TestMethod()]
        public void funct_calcTest(int a, int b, char op, int exp)
        {
            int res = Functions.Calc(a, b, op);
            Assert.AreEqual(exp, res); ;
        }
    }
}