using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static double Jisuan(double a, double b, string c)
        {
            double sum=0;
            switch (c){
                case "+":sum = a + b;break;
                case "-":sum = a - b;break;
                case "*":sum = a * b;break;
                case "/":sum = a / b;break;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum;
           sum = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= sum;)
            {
                //随机产生0-100的数字，这里只产生了三个
                //Random rd1 = new Random(System.DateTime.Now.Millisecond);
                // double a = rd1.Next(100);
                double a = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
                double b = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);


                double c = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
                //随机产生符号
                int s = new Random(Guid.NewGuid().GetHashCode()).Next(0,5)*2;
                string[] fu = { "+", "-", "*","+","*","-", "/","+","/","-","-","+" };
                string fu1 = fu[s];
                double he1 = Jisuan(a, b, fu1);

                if (he1%2==0&&he1>0)
                {
                    string fu2 = fu[s+1];
                 
                    double he2 = Jisuan(he1,c, fu2);
                    if (he2 % 2 == 0&&he2>0)
                    {
                        Console.WriteLine(a+" " +fu1+" "+b+" "+fu2+" "+c+" = "+he2);
                        Console.WriteLine();
                        i++;
                           
                    }
                    
                }


            }
            Console.ReadKey();
        }
        
    }
}
