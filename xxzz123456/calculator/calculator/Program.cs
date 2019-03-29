using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class 表达式
    {
        string a, b, c, d, op1, op2, op3;
        string[] op = { "+", "-", "*", "/" };
        public 表达式(int a, int b, int c, int d, int x, int y, int z)
        {
            this.a = Convert.ToString(a);
            this.b = Convert.ToString(b);
            this.c = Convert.ToString(c);
            this.d = Convert.ToString(d);
            op1 = op[x];
            op2 = op[y];
            op3 = op[z];
        }
        public string 输出两个运算符()
        {
            string result;
            result = a + " " + op1 + " " + b + " " + op2 + " " + c;

            return result;
        }
        public string 输出三个运算符()
        {
            string result;
            result = a + " " + op1 + " " + b + " " + op2 + " " + c + " " + op3 + " " + d;

            return result;
        }
        public string[] 分隔并计算(string result)
        {
            Stack<string> OPTR = new Stack<string>();
            Stack<string> OPND = new Stack<string>();
            Stack<string> OPTR1 = new Stack<string>();
            Stack<string> OPND1 = new Stack<string>();
            string m = result;
            string[] n = m.Split(' ');

            int count = n.Length;
            Random bdm = new Random();
            for (int t = 0; t < count; t++)
            {
                if (n[t] != "+" && n[t] != "-" && n[t] != "*" && n[t] != "/")
                {
                    OPND.Push(n[t]);
                }
                else
                {
                    OPTR.Push(n[t]);

                    if (n[t] == "*" || n[t] == "/")
                    {
                        OPND.Push(n[t + 1]);
                        t++;
                        string x, y, z;
                        x = OPND.Pop();
                        y = OPND.Pop();
                        z = 二元运算(y, OPTR.Pop(), x).ToString();
                        OPND.Push(z);
                    }
                }
            }
            while (OPND.Count != 0)
            {
                OPND1.Push(OPND.Pop());
                if (OPND.Count == 0) break;
                OPTR1.Push(OPTR.Pop());
            }
            while (OPTR1.Count != 0 && OPND1.Count != 0)
            {
                string x, y, z;
                x = OPND1.Pop();
                y = OPND1.Pop();
                z = 二元运算(x, OPTR1.Pop(), y).ToString();
                OPND1.Push(z);
            }
            result = OPND1.Pop();
            string[] q = { m, result };
            return q;
        }
        public int 二元运算(string x, string op, string y)
        {
            int result;
            if (op == "+")
                result = Convert.ToInt32(x) + Convert.ToInt32(y);
            else if (op == "-")
            {
                result = Convert.ToInt32(x) - Convert.ToInt32(y);
            }
            else if (op == "*")
                result = Convert.ToInt32(x) * Convert.ToInt32(y);
            else
            {
                if (Convert.ToInt32(x) % Convert.ToInt32(y) == 0)
                    result = Convert.ToInt32(x) / Convert.ToInt32(y);
                else
                    return -1;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n, a1, b1, c1, d1, op1, op2, op3;
            string result;
            Random adm = new Random();
            Console.WriteLine("请输入方程个数：");
            n = int.Parse(Console.ReadLine());
            int a, b;
            a = n / 2;
            b = n - a;
            for (int i = 0; i < a; i++)
            {
                a1 = adm.Next(101);
                b1 = adm.Next(101);
                c1 = adm.Next(101);
                d1 = adm.Next(101);
                op1 = adm.Next(4);
                op2 = adm.Next(4);
                op3 = adm.Next(4);
                if (op1 == 3)
                {
                    b1 = adm.Next(1,20);
                    for (int h = 0; h < 100; h++)
                    {
                        a1 = adm.Next(1,20) * b1;
                        if (a1 < 101) break;
                    }
                }
                if (op2 == 3)
                {
                    c1 = adm.Next(1,20);
                    for (int h = 0; h < 100; h++)
                    {
                        b1 = adm.Next(1,20) * c1;
                        if (b1 < 101) break;
                    }
                }
                表达式 c = new 表达式(a1, b1, c1, d1, op1, op2, op3);
                result = c.输出两个运算符();
                string[] q = c.分隔并计算(result);
                c.分隔并计算(result);
                if (int.Parse(q[1]) < 0)
                {
                    i--;
                    continue;
                }
                else
                {
                    Console.WriteLine(q[0] + "=" + q[1]);
                }
            }
            for (int i = 0; i < b; i++)
            {
                a1 = adm.Next(101);
                b1 = adm.Next(101);
                c1 = adm.Next(101);
                d1 = adm.Next(101);
                op1 = adm.Next(4);
                op2 = adm.Next(4);
                op3 = adm.Next(4);
                if (op3 == 3)
                {
                    d1 = adm.Next(1,20);
                    for (int h = 0; h < 100; h++)
                    {
                        c1 = adm.Next(1,20) * d1;
                        if (c1 < 101) break;
                    }
                }

                if (op2 == 3)
                {
                    c1 = adm.Next(1,20);
                    for (int h = 0; h < 100; h++)
                    {
                        b1 = adm.Next(1,20) * c1;
                        if (b1 < 101) break;
                    }
                }
                if (op1 == 3)
                {
                    b1 = adm.Next(1,20);
                    for (int h = 0; h < 100; h++)
                    {
                        a1 = adm.Next(1,20) * b1;
                        if (a1 < 101) break;
                    }
                }
                表达式 c = new 表达式(a1, b1, c1, d1, op1, op2, op3);
                result = c.输出三个运算符();
                string[] q = c.分隔并计算(result);
                c.分隔并计算(result);
                if (int.Parse(q[1]) < 0)
                {
                    i--;
                    continue;
                }
                else
                {
                    Console.WriteLine(q[0] + "=" + q[1]);
                }
            }
            Console.ReadLine();
        }
    }
}
