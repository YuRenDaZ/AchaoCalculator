using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 博客第二次作业;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //测试check函数,期待值和实际值相比；
            Program one = new Program();
            int x = 2;
            int y = 5;
            int op1 = 1;
            Assert.AreEqual(one.Check(op1,x,y),7);
            //测试XX函数
            int m = 5;
            int n = 4;
            int op2 = 3;
            Assert.AreEqual(one.XX(op2, m, n), 20);



        }
    }
}
