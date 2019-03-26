using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class At
    {
        public int suijishu()
        {
            int m = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);      
            return m;                
        }
        public double jisuan(double c,double d,char e)
        {
            switch (e)
            {
                case '+':
                    return c + d;
                case '-':
                    return c - d;
                case '*':
                    return c * d;
                default:
                    return c / d;
            }

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("用户输入题目数n：");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Random a = new Random();
                At f = new At();
                int g = f.suijishu();
                int h = f.suijishu();
                double p;
                char[] FH = { '+', '-', '*', '/' };
                char m = FH[new Random(Guid.NewGuid().GetHashCode()).Next(0, 4)];
                p = f.jisuan(g, h, m);
                if (p < 0)
                {
                    i = i - 1;
                    continue;
                }
                string q = p.ToString();
                if (q.Contains(".") == true)
                {
                    i = i - 1;
                    continue;
                }
                Console.WriteLine(g + "" + m +""+ h + "" + "=" + p);
                
            }
            Console.ReadKey();
        }
    }
}
