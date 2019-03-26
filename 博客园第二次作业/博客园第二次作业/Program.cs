using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 博客园第二次作业
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = { "+", "-", "*", "/" };
            string[] t = { "*", "/" };
            for (int i = 0; i < n;)
            {
                Random M = new Random(Guid.NewGuid().GetHashCode());
                Random A = new Random(Guid.NewGuid().GetHashCode());
                double a = A.Next(0, 100);
                double b = A.Next(0, 100);
                double c = A.Next(0, 100);
                int x = M.Next(0, 2);
                int y = M.Next(0, 4);
                double sum = 0;
                switch (x)
                {
                    case 0:
                        sum = a * b;
                        break;
                    case 1:
                        sum = a / b;
                        break;

                }
                if (sum == (int)sum)
                {
                    switch (y)
                    {
                        case 0:
                            sum = sum + c;
                            break;
                        case 1:
                            sum = sum - c;
                            break;
                        case 2:
                            sum = sum * c;
                            break;
                        case 3:
                            sum = sum / c;
                            break;
                    }
                    if (sum == (int)sum)
                    { Console.WriteLine(a + t[x] + b + s[y] + c + "=" + sum); i++; }
                }
            }
            Console.ReadKey();
        }
    }
}
