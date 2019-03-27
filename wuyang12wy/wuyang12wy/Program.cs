using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wuyang12wy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入练习次数");
            int count=int.Parse(Console.ReadLine());
            operationMethod method = new operationMethod();
           
      
            for (int i = 0;i < count; i++)
            {
                
                int op = new Random().Next(4);
                Thread.Sleep(100);
                switch(op)
                {
                    case 0:
                        {
                            string res= method.add();
                            Console.WriteLine(res);
                            break;
                        }
                    case 1:
                        {
                            string res = method.jian();
                            Console.WriteLine(res);
                            break;
                        }
                    case 2:
                        {
                            string res = method.chen();
                            Console.WriteLine(res);
                            break;
                        }
                    case 3:
                        {
                            string res = method.chu();
                            Console.WriteLine(res);
                            break;
                        }

                }
            }
            Console.ReadLine();
        }
    }
    class operationMethod
    {
        public string add()
        { 
            
            Random random = new Random();
           
            int numA = random.Next(99);
            int numB = random.Next(99);
            string res = numA + "+" + numB +" = "+(numA+numB);
            return res;
        }
        public string jian()
        {
            Random random = new Random();
            int numA = random.Next(99);
            int numB = random.Next(99);
            string res = numA + "-" + numB + " = " + (numA - numB);
            return res;
        }
        public string chen()
        {
            Random random = new Random();
            int numA = random.Next(99);
            int numB = random.Next(99);
            string res = numA + "*" + numB + " = " + (numA * numB);
            return res;

        }
        public string chu()
        {
            Random random = new Random();
            int numA = random.Next(99);
            int numB = random.Next(99);
            string res = numA + "/" + numB + " = " + (numA / numB);
            return res;
        }
    }
}
