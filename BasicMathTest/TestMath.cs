using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BasicMaths;

namespace BasicMathTest
{
    [TestClass]
    public class TestMath
    {
        [TestMethod]
        public  static TestAdd()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public static Test_SubstractMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public  static Test_DivideMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public static Test_MultiplyMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
