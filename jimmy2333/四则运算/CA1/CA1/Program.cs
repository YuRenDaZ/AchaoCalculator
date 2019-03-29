using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("请输入练习题数目：");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {   
                Random r = new Random();
                int a = r.Next(0, 100);
                int b = r.Next(0, 100);
                int c = r.Next(0, 100);
                string[] e = { "+", "-", "*", "/" };
                char f, h;
                Random g = new Random();
                int x = g.Next(0, 3);
                int re = g.Next(0, 3);
                f = char.Parse(e[x % 4]);
                h = char.Parse(e[re % 4]);
                switch (f)
                {
                    case '+':
                        switch (h)
                        {
                            case '+':
                                Console.WriteLine(a + "+" + b + "+" + c + "=");
                                Console.ReadKey();
                                break;
                            case '-':
                                Console.WriteLine(a + "+" + b + "-" + c + "=");
                                Console.ReadKey();
                                break;
                            case '*':
                                Console.WriteLine(a + "+" + b + "*" + c + "=");
                                Console.ReadKey();
                                break;
                            case '/':
                                Console.WriteLine(a + "+" + b + "/" + c + "=");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case '-':
                        switch (h)
                        {
                            case '+':
                                Console.WriteLine(a + "-" + b + "+" + c + "=");
                                Console.ReadKey();
                                break;
                            case '-':
                                Console.WriteLine(a + "-" + b + "-" + c + "=");
                                Console.ReadKey();
                                break;
                            case '*':
                                Console.WriteLine(a + "-" + b + "*" + c + "=");
                                Console.ReadKey();
                                break;
                            case '/':
                                Console.WriteLine(a + "-" + b + "/" + c + "=");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case '*':
                        switch (h)
                        {
                            case '+':
                                Console.WriteLine(a + "*" + b + "+" + c + "=");
                                Console.ReadKey();
                                break;
                            case '-':
                                Console.WriteLine(a + "*" + b + "-" + c + "=");
                                Console.ReadKey();
                                break;
                            case '*':
                                Console.WriteLine(a + "*" + b + "*" + c + "=");
                                Console.ReadKey();
                                break;
                            case '/':
                                Console.WriteLine(a + "*" + b + "/" + c + "=");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case '/':
                        switch (h)
                        {
                            case '+':
                                Console.WriteLine(a + "/" + b + "+" + c + "=");
                                Console.ReadKey();
                                break;
                            case '-':
                                Console.WriteLine(a + "/" + b + "-" + c + "=");
                                Console.ReadKey();
                                break;
                            case '*':
                                Console.WriteLine(a + "/" + b + "*" + c + "=");
                                Console.ReadKey();
                                break;
                            case '/':
                                Console.WriteLine(a + "/" + b + "/" + c + "=");
                                Console.ReadKey();
                                break;
                        }
                        break;
                }

            }
        }


    }
}