using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void PC(int n)
        {
            Random ran = new Random();
            string a = "";
            string b = "";
            float result = 0;
            for (int i = 0; i < n; i++)
            {
                int x = ran.Next(0, 6);
                float  num1 = ran.Next(0, 100);
                float  num2 = ran.Next(0, 100);
                float  num3 = ran.Next(1, 100);
                switch (x)
                {
                    case 0:
                        a = "+";
                        b = "+";
                        result = num1 + num2 + num3;
                        Console.WriteLine(num1.ToString() + a + num2 + b + num3 + "=" + result);
                        break;
                    case 1:
                        a = "+";
                        b = "-";
                        result = num1 + num2 - num3;
                        if (result >0)
                        {
                            Console.WriteLine(num1.ToString() + a + num2 + b + num3 + "=" + result);
                        }
                        else
                        {
                            x = ran.Next(0, 6);
                            i--;
                        }
                        break;
                    case 2:
                        a = "+";
                        b = "*";
                        result = num1 + num2 * num3;
                        Console.WriteLine(num1.ToString() + a + num2 + b + num3 + "=" + result);
                        break;
                    case 3:
                        a = "+";
                        b = "/";
                        result = num1 + num2 / num3;
                        if (num2%num3==0)
                        {
                            Console.WriteLine(num1.ToString() + a + num2 + b + num3 + "=" + result);
                        }
                        else
                        {
                            x = ran.Next(0, 6);
                            i--;
                        }
                        break;
                    case 4:
                        a = "-";
                        b = "*";
                        result = num1 - num2 * num3;
                        if (result >0)
                        {
                            Console.WriteLine(num1.ToString() + a + num2 + b + num3 + "=" + result);
                        }
                        else
                        {
                            x = ran.Next(0, 6);
                            i--;
                        }
                        break;
                    case 5:
                        a = "-";
                        b = "/";
                        result = num1 - num2 / num3;
                        if (result>0&&num2 % num3 == 0)
                        {
                            Console.WriteLine(num1.ToString() + a + num2 + b + num3 + "=" + result);
                        }
                        else
                        {
                            x = ran.Next(0, 6);
                            i--;
                        }
                        break;
                    case 6:
                        a = "*";
                        b = "/";
                        result = num1 * num2 / num3;
                        if (num2 % num3 == 0)
                        {
                            Console.WriteLine(num1.ToString() + a + num2 + b + num3 + "=" + result);
                        }
                        else
                        {
                            x = ran.Next(0, 6);
                            i--;
                        }
                        break;
                }
                
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要生成题目个数：");
            int n = Convert .ToInt32 (Console.ReadLine ());
            PC(n);
            Console.ReadKey();
        }
    }
}
