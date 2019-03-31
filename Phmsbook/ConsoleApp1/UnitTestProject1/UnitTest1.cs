﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            void Create1(int x, int y)//加法
            {
                int z = x + y;
                Console.WriteLine(x + "+" + y + "=" + z);
            }
             void Create2(int x, int y)//减法
            {
                int z = x + y;
                Console.WriteLine(z + "-" + y + "=" + x);
            }
             void Create3(int x, int y)//乘法
            {
                int z = x * y;
                Console.WriteLine(x + "*" + y + "=" + z);
            }
             void Create4(int x, int y)//除法
            {
                int z = x * y;
                Console.WriteLine(z + "/" + y + "=" + x);
            }
             void Main(string[] args)
            {
                Random rd = new Random();
                rd.Next();
                Console.WriteLine("请输入要生成的四则运算的个数");
                int i = int.Parse(Console.ReadLine());//输入需要生成的个数
                for (int v = 0; v < i; v++)
                {
                    int a = rd.Next(1, 5);//生成4个随机数，分别代表加减乘除
                    int x = rd.Next(0, 100);
                    int y = rd.Next(0, 100);
                    switch (a)
                    {

                        case 1:
                            Create1(x, y);
                            break;
                        case 2:
                            Create2(x, y);
                            break;
                        case 3:
                            Create3(x, y);
                            break;
                        case 4:
                            Create4(x, y);
                            break;

                    }

                }
            }
        }
    }
}
