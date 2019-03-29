using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

           
                Random ra = new Random();
                Console.WriteLine("输入要打印的题目数");
                int n = int.Parse(Console.ReadLine());
            for (int p = 0; p < n; p++)
                {
                int i = ra.Next(1, 80);
                int j = ra.Next(1, 80);
                char[] a = new char[4] { '+', '-', '*', '/' };
               
                char fil = a[ra.Next(0,4)];
                if (fil == '+')
                    Console.WriteLine("{0}+{1}={2}\t", i, j, i + j);
                else  if (fil == '-')
                    Console.WriteLine("{0}-{1}={2}\t", i, j, i - j);
                else if (fil == '*')
                    Console.WriteLine("{0}*{1}={2}\t", i, j, i * j);

                else if (fil == '/')
                    Console.WriteLine("{0}/{1}={2}\t", i, j, i / j);


            }
            Console.ReadLine();
            


        }
    }
}
