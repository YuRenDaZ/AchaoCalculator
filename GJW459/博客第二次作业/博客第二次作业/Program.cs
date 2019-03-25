using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 博客第二次作业
{
    public  class Program
    {
        public static Random a = new Random();


        //随机生成四则运算的函数
        public void Abc(int n)
        {
            int sum;
            for (int i = 0; i < n; i++)
            {

                int op = a.Next(2, 4);
                switch (op)
                {
                    case 2:

                        {

                            int b = a.Next(1, 100);
                            int c = a.Next(1, 100);
                            int d = a.Next(1, 100);
                            sum = Check(a.Next(1, 5), b, c);
                            sum = XX(a.Next(1, 5), sum, d);
                                Console.Write("=" + sum);
                                Console.WriteLine();
                         

                        }
                        break;
                    default:
                        {
                            int b1 = a.Next(1, 100);
                            int c1 = a.Next(1, 100);
                            int d1 = a.Next(1, 100);
                            int e = a.Next(1, 100);
                            sum = Check(a.Next(1, 5), b1, c1);
                            sum = XX(a.Next(1, 5), sum, d1);
                            sum = XX(a.Next(1, 5), sum, e);
                                Console.Write("=" + sum);
                                Console.WriteLine();
                            
                        }
                        break;



                }

            }
        }
        public int Check(int op, int a, int b)
        {


            switch (op)
            {
                case 1:
                    {
                        Console.Write(a + "+" + b);
                        return a + b;
                    }




                case 2:

                    {
                        Console.Write(a + "-" + b);
                        return a - b;
                    }




                case 3:
                    {
                        Console.Write(a + "*" + b);
                        return a * b;

                    }

                default:
                    {
                        if (a % b == 0)
                        {
                            Console.Write(a + "÷" + b);
                            return a / b;
                        }
                        else
                        {
                            Console.Write(a + "÷" + b);
                            return 0;
                        }
                    }




            }
        }
        public int XX(int x, int y, int z)
        {
            switch (x)
            {

                case 1:
                    {
                        Console.Write("+" + z);
                        return y + z;
                       
                    }




                case 2:

                    {
                        Console.Write("-" + z);
                        return y - z;
                    }



                case 3:
                    {
                        Console.Write("*" + z);
                        return y * z;

                    }

                default:
                    {
                        if (y % z == 0)
                        {
                            Console.Write("÷" + z);
                            return y / z;
                        }
                        else
                        {
                            Console.Write("÷" + z);
                            return 0;
                        }
                    }
            }
        }



        public static void Main(string[] args)
        {
            //声明Random类型的对象
            Random a = new Random();
            //命令行参数
            Console.WriteLine("出的题目数");
            int n = int.Parse(Console.ReadLine());
            Program one = new Program();
            one.Abc(n);
            Console.ReadKey();


        }

    }
}