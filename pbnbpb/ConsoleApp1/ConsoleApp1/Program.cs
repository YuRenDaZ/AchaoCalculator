using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
   public  class Program
    {
        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        static void Main(string[] args)
        {
            string newTxtPath = "E:/作业二/AchaoCalculator/subject.txt";
            StreamWriter sw = new StreamWriter(newTxtPath, false, Encoding.Default);
            Console.WriteLine("需要多少运算题");
            int n = int.Parse(Console.ReadLine());
            int i, j, m, q, ans, temp;
            string formula;
            for (i = 0; i < n; i++)
            {

                Random ro = new Random(GetRandomSeed());
                int up, down;
                up = 100;
                down = 1;
                j = ro.Next(down, up);
                m = ro.Next(down, up);
                q = ro.Next(1, 4);
                switch (q)
                {
                    case 1:
                        ans = result(j, m);
                        formula = j + "+" + m + "=" + ans;
                        sw.WriteLine(formula);
                        Console.WriteLine(formula);
                        break;
                    case 2:
                        if (j < m)
                        {
                            temp = j;
                            j = m;
                            m = temp;
                        }
                        ans = result1(j, m);
                        formula = j + "-" + m + "=" + ans;
                        sw.WriteLine(formula);
                        Console.WriteLine(formula);
                        break;
                    case 3:
                        ans = result2(j, m);
                        formula = j + "*" + m + "=" + ans;
                        sw.WriteLine(formula);
                        Console.WriteLine(formula);
                        break;
                    case 4:
                        if (j % m != 0) ans = result2(j, m);
                        else ans = result3(j, m);
                        formula = j + "/" + m + "=" + ans;
                        sw.WriteLine(formula);
                        Console.WriteLine(formula);
                        break;
                    default:
                        break;
                }
               
            }

            sw.Flush();
            sw.Close();
            Console.ReadKey();

        }

        static  public  int result(int a, int b)
           {
                return a + b;
            }
            static public  int result1(int a, int b)
            {
                return a - b;
            }
            static public  int result2(int a, int b)
            {
                return a * b;
            }
            static public  int result3(int a, int b)
            {
                return a / b;
            }

        
    }

}
