using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要出题的个数：");
            int num = Convert.ToInt32(Console.ReadLine());
            Random ran = new Random();
            int a, b, c, r;           
            for(int i=0; i<=num;i++)
            {
                a = ran.Next(1, 100);
                b = ran.Next(1, 10);
                c = ran.Next(1, 50);
                string t = Convert.ToString(ran.Next(5));
                switch(t)
                {
                    case "0":
                        r = a + b - c;
                        Console.WriteLine("{0} + {1} - {2} = {3}",a,b,c,r);
                        break;
                    case "1":
                        r = a * b - c;
                        Console.WriteLine("{0} * {1} - {2} = {3}",a,b,c,r);
                        break;
                    case "2":
                        r = a / b - c;
                        if (a % b == 0)
                        {
                            Console.WriteLine("{0} / {1} - {2} = {3}", a, b, c, r);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "3":
                        r = a + b;
                        Console.WriteLine("{0} + {1} = {2}",a,b,r);
                        break;
                    case "4":
                        r = a - b;
                        Console.WriteLine("{0} - {1} = {2}",a,b,r);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
