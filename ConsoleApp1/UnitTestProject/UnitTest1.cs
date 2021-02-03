using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase01()
        {
            PositiveDivisors devisors = new PositiveDivisors();
            string result = devisors.returnDivisors(42);
            Assert.AreEqual(result, "1 2 3 6 7 14 21 42 ");

        }

        [TestMethod]
        public void TestCase02()
        {
            PositiveDivisors devisors = new PositiveDivisors();
            string result = devisors.returnDivisors(60);
            Assert.AreEqual(result, "1 2 3 4 5 6 10 12 15 20 30 60 ");

        }

        [TestMethod]
        public void TestCase03()
        {
            PositiveDivisors devisors = new PositiveDivisors();
            string result = devisors.returnDivisors(100);
            Assert.AreEqual(result, "1 2 4 5 10 20 25 50 100 ");

        }

        [TestMethod]
        public void TestCase04()
        {
            PositiveDivisors devisors = new PositiveDivisors();
            var ex = Assert.ThrowsException<Exception>(() => devisors.returnDivisors(-15));
            Assert.AreSame(ex.Message, "Must be positive int value, Bad input format!");

        }

    }
}
