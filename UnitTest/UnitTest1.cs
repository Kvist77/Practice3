using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practic3;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double R = Math.Sqrt(3);
            double S = Program.S(R);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double R = 1;
            double S = Program.S(R);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double R =2.5;
            double S = Program.S(R);
        }
    }
}
