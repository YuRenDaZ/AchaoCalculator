using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AchaoCalculator
    {
        public void system()
        {
            Random a = new Random(Guid.NewGuid().GetHashCode());
            Random b = new Random(Guid.NewGuid().GetHashCode());
            Random c = new Random(Guid.NewGuid().GetHashCode());
            Random d = new Random(Guid.NewGuid().GetHashCode());
            Random n = new Random(Guid.NewGuid().GetHashCode());
            int a1, b1, c1, d1, n1;
            int result;
            a1 = a.Next(1, 100);
            b1 = b.Next(1, 100);
            c1 = c.Next(1, 100);
            d1 = d.Next(1, 100);
            n1 = n.Next(1, 8);
            switch (n1)
            {
                case 1:
                    result = a1 + b1 + c1;
                    Console.WriteLine(a1 + "+" + b1 + "+" + c1 + "=" + result);
                    break;
                case 2:
                    if (a1 > b1)
                    {
                        result = (a1 - b1) * c1;
                        Console.WriteLine("(" + a1 + "-" + b1 + ")" + "*" + c1 + "=" + result);
                    }
                    else
                    {
                        result = (a1 + b1) * c1;
                        Console.WriteLine("(" + a1 + "+" + b1 + ")" + "*" + c1 + "=" + result);
                    }
                    break;
                case 3:
                    if ((a1 * b1) %c1 == 0)
                    {
                        result = a1 * b1 / c1;
                        Console.WriteLine(a1 + "*" + b1 + "/" + c1 + "=" + result);
                    }
                    else
                    {
                        result = a1 * b1 * c1;
                        Console.WriteLine(a1 + "*" + b1 + "*" + c1 + "=" + result);
                    }
                    break;
                case 4:
                    if (a1 % b1 == 0)
                    {
                        result = a1 / b1 + c1;
                        Console.WriteLine(a1 + "/" + b1 + "+" + c1 + "=" + result);
                    }
                    else if (b1 % a1 == 0)
                    {
                        result = b1 / a1 + c1;
                        Console.WriteLine(b1 + "/" + a1 + "+" + c1 + "=" + result);
                    }
                    else
                    {
                        result = a1 * b1 + c1;
                        Console.WriteLine(a1 + "*" + b1 + "+" + c1 + "=" + result);
                    }

                    break;
                case 5:
                    if ((a1+b1)>c1)
                    {
                        result = a1 + b1 - c1;
                        Console.WriteLine(a1 + "+" + b1 + "-" + c1 + "=" + result);
                    }
                    else
                    {
                        result = c1 - a1 - b1;
                        Console.WriteLine(c1 + "-" + a1 + "-" + b1 + "=" + result);
                    }
                    break;
                case 6:
                    if((a1+b1+c1)>d1)
                    {
                        result = d1 + c1 + b1 - a1;
                        Console.WriteLine(d1 + "+" + a1 + "+" + b1 + "-" + c1 + "=" + result);
                    }
                    else if((a1+b1)>(c1+d1))
                    {
                        result = a1 + b1 - c1 - d1;
                        Console.WriteLine(a1 + "+" + b1 + "-" + c1 + "-" + d1 + "=" + result);
                    }
                    else
                    {
                        result = d1 - c1 - b1 - a1;
                        Console.WriteLine(d1 + "-" + c1 + "-" + b1 + "-" + a1 + "=" + result);
                    }
                    break;
                case 7:
                    if((a1%b1)==0&&(c1%d1)==0)
                    {
                        result = a1 / b1 + c1 / d1;
                        Console.WriteLine(a1 + "/" + b1 + "+" + c1 + "/" + d1 + "=" + result);
                    }
                    else if((a1%b1)==0&&(c1%d1)!=0)
                    {
                        result = a1 / b1 + c1 * d1;
                        Console.WriteLine(a1 + "/" + b1 + "+" + c1 + "*" + d1 + "=" + result);
                    }
                    else
                    {
                        result = a1 * b1 + c1 * d1;
                        Console.WriteLine(a1 + "*" + b1 + "+" + c1 + "*" + d1 + "=" + result);
                    }
                    break;
                case 8:
                    if (a1 > (b1 + c1) && a1 > d1) 
                    {
                        result = (a1 - b1 - c1) * d1;
                        Console.WriteLine("("+a1 + "-" + b1 + "-" + c1+")" + "*" + d1 + "=" + result);
                    }
                    else if(a1 > (b1 + c1) && a1 < d1)
                    {
                        result = (b1 + c1 - a1) * d1;
                        Console.WriteLine("(" + b1 + "+" + c1 + "-" + a1 + ")" + "*" + d1 + "=" + result);
                    }
                    else
                    {
                        result = (a1 + b1 + c1) * d1;
                        Console.WriteLine("(" + a1 + "+" + b1 + "+" + c1 + ")" + "*" + d1 + "=" + result);
                    }
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AchaoCalculator AC = new AchaoCalculator();
            Console.WriteLine("请输入题目数量：");      
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                AC.system();
            }
            Console.ReadLine();
        }
    }
}
