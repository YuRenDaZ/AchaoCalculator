using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Program
    {
        public void prf(int m)
        {
            double result;
            int num1, num2, num3;
            double l;
            Random rd = new Random();
            
            for (int i = 0; i < m; i++)
            {
                num1 = rd.Next(1, 100);
                num2 = rd.Next(1, 100);
                num3 = rd.Next(1, 100);
                int n = rd.Next(1, 15);

                switch (n)
                {
                    case 1:
                        result = num1 + num2 + num3;
                        Console.WriteLine(num1 + "+" + num2 + "+" + num3 + "=" + result);
                        
                        
                        break;
                    case 2:
                        result = num1 + num2 - num3;
                        Console.WriteLine(num1 + "+" + num2 + "-" + num3+"="+result);
                        break;
                    case 3:
                        result = num1 - num2 - num3;
                        Console.WriteLine(num1 + "-" + num2 + "-" + num3 + "=" + result);
                        break;
                    case 4:
                        result = num1 * num2 * num3;
                        Console.WriteLine(num1 + "*" + num2 + "*" + num3 + "=" + result);
                        break;
                    case 5:
                        result = num1 * num2 / num3;
                        if (result == Math.Ceiling(result))
                        {

                            Console.WriteLine(num1 + "*" + num2 + "/" + num3 + "=" + result);
                        }
                        else
                            continue;
                       /* Console.WriteLine(num1 + "*" + num2 + "/" + num3 + "=" + result);*/
                        break;
                    case 6:
                        result = num1 / num2 / num3;
                        if (result == Math.Ceiling(result))
                        {

                            Console.WriteLine(num1 + "/" + num2 + "/" + num3 + "=" + result); ;
                        }
                        else
                            continue;
                        /* Console.WriteLine(num1 + "/" + num2 + "/" + num3 + "=" + result);*/
                        break;
                    case 7:
                        result = num1 / num2 * num3;
                        /*Console.WriteLine(num1 + "/" + num2 + "*" + num3 + "=" + result);*/
                        if (result == Math.Ceiling(result))
                        {

                            Console.WriteLine(num1 + "/" + num2 + "*" + num3 + "=" + result);
                        }
                        else
                            continue;
                        break;
                    case 8:
                        result = num1 + num2 * num3;
                        Console.WriteLine(num1 + "+" + num2 + "*" + num3 + "=" + result);
                        break;
                    case 9:
                        result = num1 * num2 + num3;
                        Console.WriteLine(num1 + "*" + num2 + "+" + num3 + "=" + result);
                        break;
                    case 10:
                        result = num1 - num2 * num3;
                        Console.WriteLine(num1 + "-" + num2 + "*" + num3 + "=" + result);
                        break;
                    case 11:
                        result = num1 * num2 - num3;
                        Console.WriteLine(num1 + "*" + num2 + "-" + num3 + "=" + result);
                        break;
                    case 12:
                        result = num1 + num2 / num3;
                       /* Console.WriteLine(num1 + "+" + num2 + "/" + num3 + "=" + result);*/
                        if (result == Math.Ceiling(result))
                        {

                            Console.WriteLine(num1 + "+" + num2 + "/" + num3 + "=" + result);
                        }
                        else
                            continue;
                        break;
                    case 13:
                        result = num1 / num2 + num3;
                       /* Console.WriteLine(num1 + "/" + num2 + "+" + num3 + "=" + result);*/
                        if (result == Math.Ceiling(result))
                        {

                            Console.WriteLine(num1 + "/" + num2 + "+" + num3 + "=" + result);
                        }
                        else
                            continue;

                        break;
                    case 14:
                        result = num1 - num2 / num3;
                        /*Console.WriteLine(num1 + "-" + num2 + "/" + num3+"="+result);*/
                        if (result == Math.Ceiling(result))
                        {

                           Console.WriteLine(num1 + "-" + num2 + "/" + num3+"="+result);
                        }
                        else
                            continue;
                        break;
                    case 15:
                        result = num1 / num2 - num3;
                       /* Console.WriteLine(num1 + "/" + num2 + "-" + num3+"="+result);*/
                        if (result == Math.Ceiling(result))
                        {

                            Console.WriteLine(num1 + "/" + num2 + "-" + num3+"="+result);
                        }
                        else
                            continue;
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("亲输入需要题目的数量：");
            int m = int.Parse(Console.ReadLine());
            Program a = new Program();
            a.prf(m);
            Console.ReadKey();
            
        }
    }
}
