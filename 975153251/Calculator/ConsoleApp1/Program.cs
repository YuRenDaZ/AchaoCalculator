using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class S
        {
            Random r = new Random();
            public int Num()//取随机数
            {
                int s = r.Next(0, 100);
                return s;
            }
            //取随机运算符
            public int F()
            {
                int s = r.Next(0, 3);
                return s;
            }
            //打印随机运算符
            public void P(int s)
            {
                if (s == 0)
                    Console.Write("+");
                else if (s == 1)
                    Console.Write("-");
                else if (s == 2)
                    Console.Write("*");
                else if (s == 3)
                    Console.Write("/");
            }
            //两位运算符算法
            public double Two(int a, int b, int c, int x, int y)
            {
                double ans;
                if (x == 0)
                {
                    if (y == 0)
                        ans = a + b + c;
                    else if (y == 1)
                        ans = a + b - c;
                    else if (y == 2)
                        ans = a + b * c;
                    else
                        ans = a + b / c;
                }
                else if (x == 1)
                {
                    if (y == 0)
                        ans = a - b + c;
                    else if (y == 1)
                        ans = a - b - c;
                    else if (y == 2)
                        ans = a - b * c;
                    else
                        ans = a - b / c;
                }
                else if (x == 2)
                {
                    if (y == 0)
                        ans = a * b + c;
                    else if (y == 1)
                        ans = a * b - c;
                    else if (y == 2)
                        ans = a * b * c;
                    else
                        ans = a * b / c;
                }
                else
                {
                    if (y == 0)
                        ans = a / b + c;
                    else if (y == 1)
                        ans = a / b - c;
                    else if (y == 2)
                        ans = a / b * c;
                    else
                        ans = a / b / c;
                }
                return ans;
            }
            //三位运算符算法
            public double Three(int a, int b, int c, int d, int x, int y, int z)
            {
                double ans;
                if (x == 0)
                {
                    if (y == 0)
                    {
                        if (z == 0)
                            ans = a + b + c + d;
                        else if (z == 1)
                            ans = a + b + c - d;
                        else if (z == 2)
                            ans = a + b + c * d;
                        else
                            ans = a + b + c / d;
                    }

                    else if (y == 1)
                    {
                        if (z == 0)
                            ans = a + b - c + d;
                        else if (z == 1)
                            ans = a + b - c - d;
                        else if (z == 2)
                            ans = a + b - c * d;
                        else
                            ans = a + b - c / d;
                    }
                    else if (y == 2)
                    {
                        if (z == 0)
                            ans = a + b * c + d;
                        else if (z == 1)
                            ans = a + b * c - d;
                        else if (z == 2)
                            ans = a + b * c * d;
                        else
                            ans = a + b * c / d;
                    }
                    else
                    {
                        if (z == 0)
                            ans = a + b / c + d;
                        else if (z == 1)
                            ans = a + b / c - d;
                        else if (z == 2)
                            ans = a + b / c * d;
                        else
                            ans = a + b / c / d;
                    }
                }
                else if (x == 1)
                {
                    if (y == 0)
                    {
                        if (z == 0)
                            ans = a - b + c + d;
                        else if (z == 1)
                            ans = a - b + c - d;
                        else if (z == 2)
                            ans = a - b + c * d;
                        else
                            ans = a - b + c / d;
                    }

                    else if (y == 1)
                    {
                        if (z == 0)
                            ans = a - b - c + d;
                        else if (z == 1)
                            ans = a - b - c - d;
                        else if (z == 2)
                            ans = a - b - c * d;
                        else
                            ans = a - b - c / d;
                    }
                    else if (y == 2)
                    {
                        if (z == 0)
                            ans = a - b * c + d;
                        else if (z == 1)
                            ans = a - b * c - d;
                        else if (z == 2)
                            ans = a - b * c * d;
                        else
                            ans = a - b * c / d;
                    }
                    else
                    {
                        if (z == 0)
                            ans = a - b / c + d;
                        else if (z == 1)
                            ans = a - b / c - d;
                        else if (z == 2)
                            ans = a - b / c * d;
                        else
                            ans = a - b / c / d;
                    }
                }
                else if (x == 2)
                {
                    if (y == 0)
                    {
                        if (z == 0)
                            ans = a * b + c + d;
                        else if (z == 1)
                            ans = a * b + c - d;
                        else if (z == 2)
                            ans = a * b + c * d;
                        else
                            ans = a * b + c / d;
                    }

                    else if (y == 1)
                    {
                        if (z == 0)
                            ans = a * b - c + d;
                        else if (z == 1)
                            ans = a * b - c - d;
                        else if (z == 2)
                            ans = a * b - c * d;
                        else
                            ans = a * b - c / d;
                    }
                    else if (y == 2)
                    {
                        if (z == 0)
                            ans = a * b * c + d;
                        else if (z == 1)
                            ans = a * b * c - d;
                        else if (z == 2)
                            ans = a * b * c * d;
                        else
                            ans = a * b * c / d;
                    }
                    else
                    {
                        if (z == 0)
                            ans = a * b / c + d;
                        else if (z == 1)
                            ans = a * b / c - d;
                        else if (z == 2)
                            ans = a * b / c * d;
                        else
                            ans = a * b / c / d;
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        if (z == 0)
                            ans = a / b + c + d;
                        else if (z == 1)
                            ans = a / b + c - d;
                        else if (z == 2)
                            ans = a / b + c * d;
                        else
                            ans = a / b + c / d;
                    }

                    else if (y == 1)
                    {
                        if (z == 0)
                            ans = a / b - c + d;
                        else if (z == 1)
                            ans = a / b - c - d;
                        else if (z == 2)
                            ans = a / b - c * d;
                        else
                            ans = a / b - c / d;
                    }
                    else if (y == 2)
                    {
                        if (z == 0)
                            ans = a / b * c + d;
                        else if (z == 1)
                            ans = a / b * c - d;
                        else if (z == 2)
                            ans = a / b * c * d;
                        else
                            ans = a / b * c / d;
                    }
                    else
                    {
                        if (z == 0)
                            ans = a / b / c + d;
                        else if (z == 1)
                            ans = a / b / c - d;
                        else if (z == 2)
                            ans = a / b / c * d;
                        else
                            ans = a / b / c / d;
                    }
                }
                return ans;
            }

        }
        static void Main(string[] args)
        {
            //定义变量
            S s = new S();
            int n, m;
            int A, B, C, D;
            double Ans;
            int X, Y, Z;
            Console.WriteLine("请输入题目个数：");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n;)
            {
                A = s.Num(); B = s.Num(); C = s.Num(); D = s.Num();
                X = s.F(); Y = s.F(); Z = s.F();
                m = s.Num();
                if (m % 2 != 0)//两位运算符
                {
                    Ans = s.Two(A, B, C, X, Y);
                    if (Ans % 1 == 0)
                    {
                        Console.Write(A);
                        s.P(X);
                        Console.Write(B);
                        s.P(Y);
                        Console.Write(C);
                        Console.Write("=");
                        Console.WriteLine(Ans);
                        i++;
                    }
                }
                else//三位运算符
                {
                    Ans = s.Three(A, B, C, D, X, Y, Z);
                    if (Ans % 1 == 0)
                    {
                        Console.Write(A);
                        s.P(X);
                        Console.Write(B);
                        s.P(Y);
                        Console.Write(C);
                        s.P(Z);
                        Console.Write(D);
                        Console.Write("=");
                        Console.WriteLine(Ans);
                        i++;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
