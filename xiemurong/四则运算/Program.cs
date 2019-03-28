using System;

namespace 四则运算
{
    public class Program
    {
        public static int result = 0;
        public static int n = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("请输入四则运算题目个数");

            while (1 == 1)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
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
            int i, a, b, c;
            char op, op1;
            Random ran = new Random();
            for (i = 0; i < n; i++)
            {
                a = ran.Next(100) + 1;
                b = ran.Next(100) + 1;
                c = ran.Next(100) + 1;
                op = mark();
                op1 = mark();
                if ((op == '+' || op == '-') && (op1 == '*' || op1 == '/'))
                {
                    result = alg(a, op, alg1(b, op1, c));

                }
                else
                {
                    result = alg1(alg(a, op, b), op1, c);
                }

                if (result < 0)
                {
                    i--;
                    continue;
                }
                else
                {
                    Console.Write("{0}{1}{2}{3}{4}", a, op, b, op1, c);
                    Console.WriteLine("=" + "{0}", (int)(100 * result + 0.5) / 100);
                }

            }


        }
        public static char mark()
        {
            int op;
            Random ran = new Random();
            op = ran.Next(3) + 1;
            switch (op)
            {
                case 1:
                    return '+';
                case 2:
                    return '-';
                case 3:
                    return '*';
                case 4:
                    return '/';
            }
            return (char)0;
        }
        //第一个运算符计算
        public static int alg(int x, char op, int y)
        {
            switch (op)
            {
                case '+': result = x + y; break;
                case '-': result = x - y; break;
                case '*': result = x * y; break;
                case '/': result = x / y; break;
            }
            return result;
        }
        //第二个运算符计算
        public static int alg1(int x, char op1, int y)
        {

            switch (op1)
            {
                case '+': result = x + y; break;
                case '-': result = x - y; break;
                case '*': result = x * y; break;
                case '/': result = x / y; break;
            }
            return result;
        }
    }
}
