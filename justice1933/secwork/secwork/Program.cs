using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitdemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Qustion qustion = new Qustion();
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine("Input is error");
            else
            {
                for (int i = 0; i < n; i++)
                    qustion.Q_write();
            }
            Console.ReadKey();
        }
    }
    public class Qustion
    {
        public void Q_write()
        {
            RandomStatic randomStatic = new RandomStatic();
            DoQ doQ = new DoQ();
            int sum = 0;
            int[] num = new int[4];
            char[] op = new char[3];
            char[] oper = new char[] { '+', '-', '*', '/' };
            for (int i = 0; i < 3; i++)
            {
                op[i] = oper[randomStatic.ProduceIntRandom(0, 3)];
            }
            for (int i = 0; i < 4; i++)
            {
                num[i] = randomStatic.ProduceIntRandom(1, 100);

            }
            for (int i = 0; i < 3; i++)
            {
                if (op[i] == '/')
                {
                    while (num[i] % num[i + 1] != 0)
                    {
                        num[i + 1] = randomStatic.ProduceIntRandom(1, 100);
                    }
                }
            }
            sum = doQ.cal(num, op);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(num[i]);
                Console.Write(op[i]);
            }
            Console.Write(num[3]);
            Console.WriteLine("={0}", sum);
        }
    }
    public class DoQ
    {
        public int cal(int[] a, char[] b)
        {
            int result = 0;
            if ((prio(b[0]) == 2 && prio(b[1]) == 1 && prio(b[2]) == 1) || (prio(b[0]) == 2 && prio(b[1]) == 2 && prio(b[2]) == 1) || (prio(b[0]) == 1 && prio(b[1]) == 1 && prio(b[2]) == 1) || (prio(b[0]) == 2 && prio(b[1]) == 2 && prio(b[2]) == 2))
            {
                result = GetValue(a[0], a[1], b[0]);
                result = GetValue(result, a[2], b[1]);
                result = GetValue(result, a[3], b[2]);
            }
            if (prio(b[0]) == 1 && prio(b[1]) == 2 && prio(b[2]) == 1)
            {
                result = GetValue(a[1], a[2], b[1]);
                result = GetValue(a[0], result, b[0]);
                result = GetValue(result, a[3], b[2]);
            }
            if (prio(b[0]) == 1 && prio(b[1]) == 1 && prio(b[2]) == 2)
            {
                result = GetValue(a[2], a[3], b[2]);
                result = GetValue(a[1], result, b[1]);
                result = GetValue(a[0], result, b[0]);
            }
            if (prio(b[0]) == 1 && prio(b[1]) == 2 && prio(b[2]) == 2)
            {
                result = GetValue(a[1], a[2], b[1]); result = GetValue(result, a[3], b[2]); result = GetValue(a[0], result, b[0]);
            }
            if (prio(b[0]) == 2 && prio(b[1]) == 1 && prio(b[2]) == 2)
            {
                result = GetValue(GetValue(a[0], a[1], b[0]), GetValue(a[2], a[3], b[2]), b[1]);
            }

            return result;

        }
        public int GetValue(int left, int right, char _operator)
        {
            switch (_operator)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    return left / right;
            }
            return 0;
        }
        public int prio(char a)
        {
            switch (a)
            {
                case '+':
                    return 1;
                case '-':
                    return 1;
                case '*':
                    return 2;
                case '/':
                    return 2;
            }
            return 0;
        }
    }

    public class RandomStatic
    {
        //产生制定范围内的随机整数
        public int ProduceIntRandom(int minValue, int maxValue)
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            return r.Next(minValue, maxValue + 1);
        }
    }
}
