using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace four_arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 1;
            int m;
            StreamWriter f = new StreamWriter(@"F:\vs_text.txt", false);
            float[] N = new float[3];
            string[] Of = new string[] { "+", "-", "*", "/" };
            string[] Ot = new string[2];
            Random rd = new Random();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)//将四个随机数放入数组N
                {
                    float a = rd.Next(0, 100);
                    N[j] = a;
                }
                for (int j = 0; j < 2; j++)//将加减乘除放入数组Ot
                {
                    int b = rd.Next(0, 4);
                    Ot[j] = Of[b];
                }
                if (Ot[0] == "*")
                {
                    if (Ot[1] == "*")
                    {
                        number = N[0] * N[1] * N[2];
                    }
                    else
                        if (Ot[1] == "/")
                    {
                        number = N[0] * N[1] / N[2];
                    }
                    else
                        if (Ot[1] == "+")
                    {
                        number = N[0] * N[1] + N[2];
                    }
                    else
                        if (Ot[1] == "-")
                    {
                        number = N[0] * N[1] - N[2];
                    }

                }
                else
                        if (Ot[0] == "/")
                {
                    if (Ot[1] == "*")
                    {
                        number = N[0] / N[1] * N[2];
                    }
                    else
                        if (Ot[1] == "/")
                    {
                        number = N[0] / N[1] / N[2];
                    }
                    else
                        if (Ot[1] == "+")
                    {
                        number = N[0] / N[1] + N[2];
                    }
                    else
                        if (Ot[1] == "-")
                    {
                        number = N[0] / N[1] - N[2];
                    }
                }
                else
                        if (Ot[0] == "+")
                {
                    if (Ot[1] == "*")
                    {
                        number = N[0] + (N[1] * N[2]);
                    }
                    else
                        if (Ot[1] == "/")
                    {
                        number = N[0] + (N[1] / N[2]);
                    }
                    else
                        if (Ot[1] == "+")
                    {
                        number = N[0] + N[1] + N[2];
                    }
                    else
                        if (Ot[1] == "-")
                    {
                        number = N[0] + N[1] - N[2];
                    }
                }
                else
                        if (Ot[0] == "-")
                {
                    if (Ot[1] == "*")
                    {
                        number = N[0] - (N[1] * N[2]);
                    }
                    else
                        if (Ot[1] == "/")
                    {
                        number = N[0] - (N[1] / N[2]);
                    }
                    else
                        if (Ot[1] == "+")
                    {
                        number = N[0] - N[1] + N[2];
                    }
                    else
                        if (Ot[1] == "-")
                    {
                        number = N[0] - N[1] - N[2];
                    }
                }
                if (number <= 0 || number % 1 != 0)
                {
                    i--;
                    continue;
                }
                m = i + 1;
                f.WriteLine("第" + m + "道题为：" + N[0] + ' ' + Ot[0] + ' ' + N[1] + ' ' + Ot[1] + ' ' + N[2] + "= " + number);
                Console.WriteLine("第" + m + "道题为：" + N[0] + ' ' + Ot[0] + ' ' + N[1] + ' ' + Ot[1] + ' ' + N[2] + "= " + number);
            }
            f.Close();
            Console.ReadKey();
        }
    }
}
