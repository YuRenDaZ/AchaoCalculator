using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static Random rd = new Random();
        static int data()
        {
            int da = rd.Next(0, 100);
            return da;
        }
        static char zf()
        {
            char[] a = new char[] { '+', '-', '*', '/' };
            int i = rd.Next(0, 4) % 4;
            return a[i];
        }
        public static string Zb(int n)
        {
            int a, c, e;
            char b, d;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                a = data();
                b = zf();
                c = data();
                d = zf();
                e = data();
                if ('/' == b)
                {
                    if (0 == c)
                    {
                        n = n + 1;
                        continue;
                    }
                    else if (a / c != (float)a / (float)c)
                    {
                        n = n + 1;
                        continue;
                    }
                }
                if ('/' == d)
                {
                    if (0 == e)
                    {
                        n = n + 1;
                        continue;
                    }
                    else if (c / e != (float)c / (float)e)
                    {
                        n = n + 1;
                        continue;
                    }
                }
                if (b == '*' || b == '/')
                {
                    if (d == '*' || d == '/')
                    {
                        if (b == '*' && d == '*')
                            sum = a * c * e;
                        else if (b == '*' && d == '/')
                            sum = a * c / e;
                        else if (b == '/' && d == '/')
                            sum = a / c / e;
                        else
                            sum = a / c * e;
                    }
                    else
                    {
                        if (b == '*' && d == '+')
                            sum = a * c + e;
                        else if (b == '*' && d == '-')
                            sum = a * c - e;
                        else if (b == '/' && d == '-')
                            sum = a / c - e;
                        else
                            sum = a / c + e;
                    }
                }
                else
                {
                    if (d == '*' || d == '/')
                    {
                        if (b == '+' && d == '*')
                            sum = a + c * e;
                        else if (b == '+' && d == '/')
                            sum = a + c / e;
                        else if (b == '-' && d == '/')
                            sum = a - c / e;
                        else
                            sum = a - c * e;
                    }
                    else
                    {
                        if (b == '+' && d == '+')
                            sum = a + c + e;
                        else if (b == '+' && d == '-')
                            sum = a + c - e;
                        else if (b == '-' && d == '-')
                            sum = a - c - e;
                        else
                            sum = a - c + e;
                    }
                }
                Console.WriteLine("{0}{1}{2}{3}{4}={5}", a, b, c, d, e, sum);
            }
            return "0";
        }
        static public void Main(string[] args)
        {
           
            Console.WriteLine("需要打印的练习题个数:");
            int n = int.Parse(Console.ReadLine());
            Zb(n);
            Console.ReadKey();
        }
        
    }
}
