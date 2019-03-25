using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random achao1 = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int a, b, c;
                a = achao1.Next(1, 100);
                b = achao1.Next(1, 100);
                c = achao1.Next(1, 100);
                string f1, f2;
                f1 = fuhao();
                f2 = fuhao();
                if (a % b == 0 && b % c == 0)
                {
                    Console.WriteLine(a + f1 + b + f2 + c + "=");
                }
                else
                {
                    n = n + 1;
                    continue;
                }
            }

            string fuhao()
            {
                Random achao2 = new Random();
                string f = "0";
                int b = achao2.Next(1, 10);
                switch (b)
                {
                    case 0:
                        f = "+"; break;
                    case 1:
                        f = "-"; break;
                    case 2:
                        f = "*"; break;
                    case 3:
                        f = "/"; break;
                }
                return f;
            }
        }
            }
        }   

