using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;//生成运算题个数
            int i,j,k;
            int temp;
            int[] b = new int[3];
            int []c=new int[2];
            Console.Write("输入运算题个数:");
            n=int.Parse(Console.ReadLine());
            Random rdm = new Random();
            for (i = 1; i <= n; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    int m = rdm.Next(1, 101);
                    b[j] = m;
                }
                for (k = 0; k < 2; k++)
                {
                    int d = rdm.Next(1, 5);
                    c[k] = d;
                }
                if ((c[0] == 1 || c[0] == 2) && (c[1] == 3 || c[1] == 4))
                {
                    Console.Write(b[0]);
                    int x = 0, y = 0;
                    while (x < 2)
                    {
                        switch (c[y])
                        {
                            case 1:
                                {
                                    x++;
                                    Console.Write(" + " + b[x]);
                                    y++;
                                    break;
                                }
                            case 2:
                                {
                                    x++;
                                    Console.Write(" - " + b[x]);
                                    y++;
                                    break;
                                }
                            case 3:
                                {
                                    x++;
                                    Console.Write(" * " + b[x]);
                                    y++;
                                    break;
                                }
                            case 4:
                                {
                                    x++;
                                    Console.Write(" / " + b[x]);
                                    y++;
                                    break;
                                }
                        }
                    }
                    Console.Write(" = ");
                    int h=2, p=1;
                    while(h>0)
                    {
                        switch (c[p])
                        {
                            case 3:
                                {
                                    temp = b[h - 1] * b[h];
                                    h--;
                                    b[h] = temp;
                                    if (p == 0)
                                        Console.WriteLine(temp);
                                    else
                                        p--;
                                    break;
                                }
                            case 4:
                                {
                                    if (b[h] != 0)
                                    {
                                        if (b[h - 1] % b[h] == 0)
                                        {
                                            temp = b[h - 1] / b[h];
                                            h--;
                                            b[h] = temp;
                                            if (p == 0)
                                                Console.WriteLine(temp);
                                            else
                                                p--;
                                        }
                                        else
                                        {
                                            h = -10;
                                            Console.WriteLine("超出所学计算范围!");
                                            p--;
                                        }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    temp = b[h - 1] - b[h];
                                    h--;
                                    b[h] = temp;
                                    if (p == 0)
                                        Console.WriteLine(temp);
                                    else
                                        p--;
                                    break;
                                }
                            case 1:
                                {
                                    temp = b[h - 1] + b[h];
                                    h--;
                                    b[h] = temp;
                                    if (p == 0)
                                        Console.WriteLine(temp);
                                    else
                                        p--;
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    Console.Write(b[0]);
                    int x = 0, y = 0;
                    while (x < 2)
                    {
                        switch (c[y])
                        {
                            case 1: 
                                {  
                                    x++;
                                    Console.Write( " + " + b[x]);
                                    y++;
                                    break;
                                }
                            case 2:
                                {
                                    x++;
                                    Console.Write(" - " +b[x]);
                                    y++;
                                    break;
                                }
                            case 3:
                                {
                                    x++;
                                    Console.Write(" * " + b[x]);
                                    y++;
                                    break;
                                }
                            case 4:
                                {    
                                    x++; 
                                    Console.Write(" / " + b[x]);
                                    y++;
                                    break;
                                }
                        }
                    }
                    Console.Write(" = ");
                    int w = 0, z = 0;
                    while (w < 2)
                    {
                        switch (c[z])
                        {
                            case 1:
                                {
                                    temp = b[w] + b[++w];
                                    b[w] = temp;
                                    if (z == 1)
                                    {
                                        Console.WriteLine(temp);
                                    }
                                    z++;
                                    break;
                                }
                            case 2:
                                {
                                    temp = b[w] - b[++w];
                                    b[w] = temp;
                                    if (z == 1)
                                    {
                                        Console.WriteLine(temp);
                                    }
                                    z++;
                                    break;
                                }
                            case 3:
                                {
                                    temp = b[w] * b[++w];
                                    b[w] = temp;
                                    if (z == 1)
                                    {
                                        Console.WriteLine(temp);
                                    }
                                    z++;
                                    break;
                                }
                            case 4:
                                {
                                    if (b[w + 1] != 0)
                                    {
                                        if (b[w] % b[w + 1] == 0)
                                        {
                                            temp = b[w] / b[++w];
                                            b[w] = temp;
                                            if (z == 1)
                                            {
                                                Console.WriteLine(temp);
                                            }
                                            else
                                                z++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("超出所学计算范围!");
                                            w = 10;
                                            z++;
                                        }
                                    }
                                    break;
                                }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
