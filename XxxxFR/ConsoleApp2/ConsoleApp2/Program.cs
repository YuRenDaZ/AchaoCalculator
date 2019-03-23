using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random ran = new Random();
           
            string b = "";
            float  result=0;
            string a = "";
            Console.WriteLine("请输入需要生成题目个数：");
            int n = Convert .ToInt32 (Console.ReadLine ());
            for (int i=0;i<n;i++)
            {
                int   x = ran.Next(0, 8);
                int   num1 = ran.Next(0, 100);
                int   num2 = ran.Next(0, 100);
                int   num3 = ran.Next(0, 100);
               
                while (num1 + num2 < num3 && x == 1)//使结果不为负
                {
                    x = ran.Next(0, 8);
                }
                while ((num2 % num3) != 0 && x == 3)//使num2/num3能得到整数
                {
                    x = ran.Next(0, 8);
                }
                while (x == 3 && num3 == 0)//使被除数不为零
                {
                    x = ran.Next(0, 8);
                }
                while (num1<(num2*num3) && x==4)
                {
                    x = ran.Next(0, 8);
                }
                while ((num2 % num3) != 0 && x == 5)
                {
                    x = ran.Next(0, 8);
                }
                while (x == 5 && num3 == 0)
                {
                    x = ran.Next(0, 8);
                }
                while (x == 5 && num1 < num2/num3)
                {
                    x = ran.Next(0, 8);
                }
                while ((num1*num2) % num3 != 0 && x == 6)
                {
                    x = ran.Next(0, 8);
                }
                while (x == 6 && num3 == 0)
                {
                    x = ran.Next(0, 8);
                }


                switch (x)
                {
                    case 0:
                        a = "+";
                        b = "+";
                        result = num1 + num2 + num3;
                        break;
                    case 1:
                        a = "+";
                        b = "-";
                        result = num1 + num2 - num3;
                        break;
                    case 2:
                        a = "+";
                        b = "*";
                        result = num1 + num2 * num3;
                        break;
                    case 3:
                        a = "+";
                        b="/";
                        result = num1 + num2 / num3;
                        break;
                    case 4:
                        a = "-";
                        b = "*";
                        result = num1 - num2 * num3;
                        break;
                    case 5:
                        a = "-";
                        b = "/";
                        result = num1 - num2 / num3;
                        break;
                    case 6:
                        a = "*";
                        b = "/";
                        result = num1 * num2 / num3;
                        break;
                }
                Console.WriteLine(num1.ToString () + a +num2 +b + num3 +"="+ result);

            }

            Console.ReadKey();

        }
    }
}
