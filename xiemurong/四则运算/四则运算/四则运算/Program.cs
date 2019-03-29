using System;

namespace 四则运算
{
    unsafe public class Program
    {
        public static int result ;
        public static int n ;
        public static void Main(string[] args)
        {
            Console.WriteLine("请输入四则运算题目个数");

            while (1 == 1)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("数字有误，请重新输入");
                }
                else
                    break;
            }
            test(n);
        }
        public static void test(int n)
        {
            int i, a, b, c,op, op1;
            int* a1 = &a;
            int* b1 = &b;
            Random ran = new Random();
            for (i = 0; i < n; i++)
            {
                a = ran.Next(100) + 1;
                b = ran.Next(100) + 1;
                c = ran.Next(100) + 1;
                op = ran.Next(4);
                op1 = ran.Next(4);
                if(op1==3)
                {
                    result = alg(&a, op, alg(&b, op1, c));
                }
                if ((op == 0 || op == 1) && (op1 == 2))
                {
                    result = alg(&a, op, alg(&b, op1, c));
                }
                else
                {
                    int temp = alg(&a, op, b);
                    result = alg(&temp, op1, c);
                }

                if (result < 0)
                {
                    i--;
                    continue;
                }
                else
                {
                    Console.Write("{0}{1}{2}{3}{4}", a, mark(op), b, mark(op1), c);
                    Console.WriteLine("=" + "{0}", result);
                }

            }
        }
        public static char mark(int op)
        {
            switch (op)
            {
                case 0:
                    return '+';
                case 1:
                    return '-';
                case 2:
                    return '*';
                case 3:
                    return '/';
            }
            return (char)0 ;
        }
        //计算
        public static int alg(int* x, int op, int y)
        {
            Random ran = new Random();
            int m;
            switch (op)
            {
                case 0: result = *x + y; break;
                case 1: result = *x - y; break;
                case 2: result = *x * y; break;
                case 3:
                    m = 100 / y;
                    *x = (ran.Next(m)+1) * y;
                    result = *x/y;
                    break;
            }
            return result;
        }
       
    }
}
