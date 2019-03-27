using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num1 = 20;
            int num2 = 53;
            Assert.AreEqual(Program.result (num1 ,num2),73);
        }
    }
}
