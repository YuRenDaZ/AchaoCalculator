using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("需要多少道算术题?");
            int k = int.Parse(Console.ReadLine());
            for(int i=0;i<k;i++)
            {
                byte[] buffer = Guid.NewGuid().ToByteArray();
                int iseed1 = BitConverter.ToInt32(buffer, 0);
               
                Random num1 = new Random(iseed1);
                
                float a = num1.Next(1, 40);
                Random num2 = new Random();
                float b = num2.Next(1, 40);
                Random num3 = new Random(iseed1);
                int c = num3.Next(1, 5);
                float result = 0;
                switch(c)
                {
                    case 1:
                        
                        result = a + b;
                        Console.WriteLine(a + "+" + b + "=" + result);
                        break;
                    case 2:
                        
                        result = a - b;
                        Console.WriteLine(a + "-" + b + "=" + result);
                        break;
                    case 3:
                        
                        result = a * b;
                        Console.WriteLine(a + "*" + b + "=" + result);
                        break;
                    case 4:
                        
                        result = a / b;
                        Console.WriteLine(a + "/" + b + "=" + result);
                        break;
                    default:
                        break;
                }
                
            }
        }
    }
}
