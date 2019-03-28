using System;
namespace ConsoleApp1
{
    class Program
    {
        int Check1(int a, int b, int c,int j,int k)
        {
            if (j <= 3 && k <= 3) return 1;
            else if (j==4&&k==3)
            {
                if (b != 0 && a % b == 0) return 1;
                else return 0;
            }
            else if(j==3&&k==4)
            {
                if (c != 0 && b % c == 0) return 1;
                else return 0;
            }
            else
            {
                if (b * c != 0 && a % (b * c) == 0) return 1;
                else return 0;
            }
        }
        int Check2(int a,int b,int c,int d,int j,int k,int l)
        {
            if(j<=3&&k<=3&&l<=3) return 1;
            else if(j==4&&k==3&&l==3)
            {
                if (b != 0 && a % b == 0) return 1;
                else return 0;
            }
            else if(j==3&&k==4&&l==3)
            {
                if (c != 0 && b % c == 0) return 1;
                else return 0;
            }
            else if(j==3&&k==3&&l==4)
            {
                if (d != 0 && c % d == 0) return 1;
                else return 0;
            }
            else if(j==4&&k==4&&l==3)
            {
                if (b * c != 0 && a % (b * c) == 0) return 1;
                else return 0;
            }
            else if(j==4&&k==3&&l==4)
            {
                if (b * d != 0 && a % b == 0 && c % d == 0) return 1;
                else return 0;
            }
            else if(j==3&&k==4&&l==4)
            {
                if (c * d != 0 && b % (c * d) == 0) return 1;
                else return 0;
            }
            else
            {
                if (b * c * d != 0 && a % (b * c * d) == 0) return 1;
                else return 0;
            }
        }
        void result1(int a,int b,int c,int j,int k)
        {
            int t1 = 0, t2=0;
            if (j <= 2 && k >= 3) Console.Write("(");
            Console.Write(a);
            switch (j)
            {
                case 1:Console.Write("+");t1 = a + b; break;
                case 2:Console.Write("-");t1 = a - b; break;
                case 3:Console.Write("*");t1 = a * b; break;
                case 4:Console.Write("/");t1 = a / b; break;
            }
            Console.Write(b);
            if (j <= 2 && k >= 3) Console.Write(")");
            switch (k)
            {
                case 1: Console.Write("+");t2 = t1 + c; break;
                case 2: Console.Write("-");t2 = t1 - c; break;
                case 3: Console.Write("*");t2 = t1 * c; break;
                case 4: Console.Write("/");t2 = t1 / c; break;
            }
            Console.Write(c);
            Console.Write("=");
            Console.WriteLine(t2);
        }
        void result2(int a,int b,int c,int d,int j,int k,int l)
        {
            int t1 = 0, t2 = 0, t3 = 0;
            if ((j <= 2 && k >= 3) || (j <= 2 && l >= 3)) Console.Write("(");
            Console.Write(a);
            switch (j)
            {
                case 1: Console.Write("+"); t1 = a + b; break;
                case 2: Console.Write("-"); t1 = a - b; break;
                case 3: Console.Write("*"); t1 = a * b; break;
                case 4: Console.Write("/"); t1 = a / b; break;
            }
            Console.Write(b);
            if (j <= 2 && k >= 3) Console.Write(")");
            switch (k)
            {
                case 1: Console.Write("+"); t2 = t1 + c; break;
                case 2: Console.Write("-"); t2 = t1 - c; break;
                case 3: Console.Write("*"); t2 = t1 * c; break;
                case 4: Console.Write("/"); t2 = t1 / c; break;
            }
            Console.Write(c);
            if (j <= 2 && k <= 2 && l >= 3) Console.Write(")");
            switch (l)
            {
                case 1: Console.Write("+"); t3 = t2 + d; break;
                case 2: Console.Write("-"); t3 = t2 - d; break;
                case 3: Console.Write("*"); t3 = t2 * d; break;
                case 4: Console.Write("/"); t3 = t2 / d; break;
            }
            Console.Write(d);
            Console.Write("=");
            Console.WriteLine(t3);
        }
        void create()
        {
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int x = ran.Next(2,4);
            if (x==2)
            {
                int a, b, c, j, k;
                do
                {
                     a = ran.Next(0, 100);
                     b = ran.Next(0, 100);
                     c = ran.Next(0, 100);
                     j = ran.Next(1, 5);
                     k = ran.Next(1, 5);
                } while (Check1(a, b, c, j, k) == 0);
                result1(a, b, c, j, k);
            }
            else
            {
                int a, b, c, d, j, k, l;
                do
                {
                    a = ran.Next(0, 100);
                    b = ran.Next(0, 100);
                    c = ran.Next(0, 100);
                    d = ran.Next(0, 100);
                    j = ran.Next(1, 5);
                    k = ran.Next(1, 5);
                    l = ran.Next(1, 5);
                } while (Check2(a, b, c, d, j, k, l) == 0);
                result2(a, b, c, d, j, k, l);
            }
        }
 
        static void Main(string[] args)
        {
            int n;
            Program a = new Program() ;
            Console.Write("请输入要生成的运算题数：");
            n=int.Parse (Console.ReadLine());
            for(int i=0;i<n;i++) a.create();
            Console.WriteLine("生成完毕！");
            Console.ReadKey();
        }
    }
}
