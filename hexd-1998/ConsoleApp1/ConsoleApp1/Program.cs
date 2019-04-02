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
            int i;
            int j;
            Console.WriteLine("请输入：");
            i=int.Parse(Console.ReadLine());
            for(j=0;j<100000;j++)
            Calculator(i);
            Console.ReadKey();
        }
        static void Calculator(int num)
        {
            Random r = new Random();
            for (int i = 0; i < num;)
            {
                double result = 0;
                double result2 = 0.0; //用于判断计算结果是否为整数
                int f = r.Next(1, 17);
                int num1 = r.Next(0, 101);
                int num2 = r.Next(0, 101);
                int num3 = r.Next(0, 101);
                if (num1!=0&&num2!=0&&num3!=0)
                    switch (f)
                {
                    case 1:
                        result = num1 + num2 + num3;
                        Console.WriteLine(num1 + " + " + num2 + " + " + num3 + " = " + result);
                        break;
                    case 2:
                        result = num1 + num2 - num3;
                        Console.WriteLine(num1 + " + " + num2 + " - " + num3 + " = " + result);
                        break;
                    case 3:
                        result = num1 + num2 * num3;
                        Console.WriteLine(num1 + " + " + num2 + " * " + num3 + " = " + result);
                        break;
                    case 4:
                        result = num1 +double.Parse((num2 / num3).ToString ());
                        result2 = num1 + double.Parse((num2 / num3).ToString());
                        if ((double)result == result2 && num3 != 0)
                        {
                            Console.WriteLine(num1 + " + " + num2 + " / " + num3 + " = " + result);
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 5:
                        result = num1 - num2 + num3;
                        Console.WriteLine(num1 + " - " + num2 + " + " + num3 + " = " + result);
                        break;
                    case 6:
                        result = num1 - num2 - num3;
                        Console.WriteLine(num1 + " - " + num2 + " - " + num3 + " = " + result);
                        break;
                    case 7:
                        result = num1 - num2 * num3;
                        Console.WriteLine(num1 + " - " + num2 + " * " + num3 + " = " + result);
                        break;
                    case 8:
                        result = num1 - double.Parse((num2 / num3).ToString());
                        result2 = num1 - double.Parse((num2 / num3).ToString());
                        if ((double)result == result2 && num3 != 0)
                        {
                            Console.WriteLine(num1 + " - " + num2 + " / " + num3 + " = " + result);
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 9:
                        result = num1 * num2 + num3;
                        Console.WriteLine(num1 + " * " + num2 + " + " + num3 + " = " + result);
                        break;
                    case 10:
                        result = num1 * num2 - num3;
                        Console.WriteLine(num1 + " * " + num2 + " - " + num3 + " = " + result);
                        break;
                    case 11:
                        result = num1 * double.Parse((num2 / num3).ToString());
                        result2 = num1 * double.Parse((num2 / num3).ToString());
                        if ((double)result == result2 && num3 != 0)
                        {
                            Console.WriteLine(num1 + " * " + num2 + " / " + num3 + " = " + result);
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 12:
                        result = double.Parse((num1 / num2).ToString()) + num3;
                        result2 = double.Parse((num1 / num2).ToString()) + num3;
                        if ((double)result == result2 && num2 != 0)
                        {
                            Console.WriteLine(num1 + " / " + num2 + " + " + num3 + " = " + result);
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 13:
                        result = double.Parse((num1 / num2).ToString()) - num3;
                        result2 = double.Parse((num1 / num2).ToString()) - num3;
                        if ((double)result == result2 && num2 != 0)
                        {
                            Console.WriteLine(num1 + " / " + num2 + " - " + num3 + " = " + result);
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 14:
                        result = double.Parse((num1 / num2).ToString()) * num3;
                        result2 = double.Parse((num1 / num2).ToString()) * num3;
                        if ((double)result == result2 && num2 != 0)
                        {
                            Console.WriteLine(num1 + " / " + num2 + " * " + num3 + " = " + result);
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 15:
                        result = num1 / num2 / num3;
                        result2 = num1 / num2 / num3;
                        if ((double)result == result2 && num2 != 0 && num3 != 0)
                        {
                            Console.WriteLine(num1 + " / " + num2 + " / " + num3 + " = " + result);
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    default:
                        result = num1 * num2 * num3;
                        Console.WriteLine(num1 + " * " + num2 + " * " + num3 + " = " + result);
                        break;
                }
                string p = result.ToString();
                int t;
                if (int.TryParse(p, out t))
                    i++;

            }

        }
    }
}
