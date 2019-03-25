using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             void  Suanfa()
            {
                int result;
                Random ran = new Random();
                int a = ran.Next(0, 100);
                int b = ran.Next(0, 100);
                int c = ran.Next(0, 100);
                int x = ran.Next(101, 104);
                int y = ran.Next(101, 104);
                if (x == 101)
                {
                    if (y == 101)
                    {
                        result = a + b + c;
                        Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, result);
                    }
                    if (y == 102)
                    {
                        result = a + b - c;
                        if (result >= 0)
                        {
                            Console.WriteLine("{0}+{1}-{2}={3}", a, b, c, result);
                        }
                        else
                        {
                            result = c + a - b;
                            Console.WriteLine("{0}+{1}-{2}={3}", c, a, b, result);
                        }
                    }
                    if (y == 103)
                    {
                        result = a + b * c;
                        Console.WriteLine("{0}+{1}*{2}={3}", a, b, c, result);
                    }
                    if (y == 104)
                    {
                        if (b % c == 0)
                        {
                            result = a + b / c;
                            Console.WriteLine("{0}+{1}/{2}={3}", a, b, c, result);
                        }
                        else
                        {
                            result = a + b + c;
                            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, result);
                        }
                    }
                }
                else if (x == 102)
                {
                    if (y == 101)
                    {
                        result = a - b + c;
                        if (result >= 0)
                        {
                            Console.WriteLine("{0}-{1}+{2}={3}", a, b, c, result);
                        }
                        else
                        {
                            result = b - a + c;
                            Console.WriteLine("{0}-{1}+{2}={3}", b, a, c, result);
                        }
                    }
                    if (y == 102)
                    {
                        result = a - b - c;
                        if (result >= 0)
                        {
                            Console.WriteLine("{0}-{1}-{2}={3}", a, b, c, result);
                        }
                        else
                        {
                            result = a + b + c;
                            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, result);
                        }
                    }
                    if (y == 103)
                    {
                        result = a - b * c;
                        if (result >= 0)
                        {
                            Console.WriteLine("{0}-{1}*{2}={3}", a, b, c, result);
                        }
                        else
                        {
                            result = b * c - a;
                            Console.WriteLine("{0}*{1}-{2}={3}", b, c, a, result);
                        }
                    }
                    if (y == 104)
                    {
                        c = c + 1;
                        if (b % c == 0)
                        {
                            result = a - b / c;
                            if (result >= 0)
                            {
                                Console.WriteLine("{0}-{1}/{2}={3}", a, b, c, result);
                            }
                            else
                            {
                                result = b - a / c;
                                Console.WriteLine("{0}-{1}/{2}={3}", b, a, c, result);
                            }
                        }
                        else
                        {
                            result = a + b * c;
                            Console.WriteLine("{0}+{1}*{2}={3}", a, b, c, result);
                        }
                    }
                }
                else if (x == 103)
                {
                    if (y == 101)
                    {
                        result = a * b + c;
                        Console.WriteLine("{0}*{1}+{2}={3}", a, b, c, result);
                    }
                    else if (y == 102)
                    {
                        result = a * b - c;
                        if (result >= 0)
                        {
                            Console.WriteLine("{0}*{1}-{2}={3}", a, b, c, result);
                        }
                        else
                        {
                            result = c - a * b;
                            Console.WriteLine("{0}-{1}*{2}={3}", c, a, b, result);
                        }
                    }
                    else if (y == 103)
                    {
                        result = a * b * c;
                        Console.WriteLine("{0}*{1}*{2}={3}", a, b, c, result);
                    }
                    else if (y == 104)
                    {
                        int d;
                        d = a * b;
                        if (d % c == 0)
                        {
                            result = a * b / c;
                            Console.WriteLine("{0}*{1}/{2}={3}", a, b, c, result);
                        }
                        else
                        {
                            result = a * b * c;
                            Console.WriteLine("{0}*{1}*{2}={3}", a, b, c, result);
                        }
                    }
                }
                else if (x == 104)
                {
                    if (a % b == 0)
                    {
                        if (y == 101)
                        {
                            result = a / b + c;
                            Console.WriteLine("{0}/{1}+{2}={3}", a, b, c, result);
                        }
                        else if (y == 102)
                        {
                            result = a / b - c;
                            if (result >= 0)
                            {
                                Console.WriteLine("{0}/{1}-{2}={3}", a, b, c, result);
                            }
                            else
                            {
                                result = c - a / b;
                                Console.WriteLine("{0}-{1}/{2}={3}", c, a, b, result);
                            }
                        }
                        else if (y == 103)
                        {
                            result = a / b * c;
                            Console.WriteLine("{0}/{1}*{2}={3}", a, b, c, result);
                        }
                        else if (y == 104)
                        {
                            if (a % b % c == 0)
                            {
                                result = a / b / c;
                                Console.WriteLine("{0}/{1}/{2}={3}", a, b, c, result);
                            }
                            else
                            {
                                result = a / b * c;
                                Console.WriteLine("{0}/{1}*{2}={3}", a, b, c, result);
                            }
                        }
                    }
                    else
                    {
                        result = a * b * c;
                        Console.WriteLine("{0}*{1}*{2}={3}", a, b, c, result);
                    }
                }
            }
            int n;
            Console.WriteLine("输入您需要的算式个数：");
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Suanfa();
            }
            Console.ReadLine();
        }
    }
}
