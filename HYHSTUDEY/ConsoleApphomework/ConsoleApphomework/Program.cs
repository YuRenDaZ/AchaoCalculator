using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApphomework
{
    class Arithmetic
    {

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            Arithmetic A = new Arithmetic();
            Random a = new Random();
            
            for (i = 0; i < n; i++)
            {
                
                int c = a.Next(1, 101);
                int d = a.Next(1, 101);
                int m = a.Next(1, 101);
                Random e = new Random();
                int q = e.Next(0, 16);
                string g="";
                string k="";
                int result = 0;
               if (c%d==0&&(c*d)%m==0&&(c%d)%m==0&&d%m==0)
                {
                    switch (q)
                    {
                        case 0:
                            g = "+";
                            k = "+";
                            result = c + d + c;
                            break;
                        case 1:
                            g = "+";
                            k = "-";
                            result = c + d - c;
                            break;
                        case 2:
                            g = "-";
                            k = "+";
                            result = c - d + c;
                            break;
                        case 3:
                            g = "+";
                            k = "*";
                            result = c + d * c;
                            break;
                        case 4:
                            g = "+";
                            k = "/";
                            result = c + d / c;
                            break;
                        case 5:
                            g = "-";
                            k = "-";
                            result = c - d - c;
                            break;
                        case 6:
                            g = "-";
                            k = "*";
                            result = c - d * c;
                            break;
                        case 7:
                            g = "-";
                            k = "/";
                            result = c - d / c;
                            break;
                        case 8:
                            g = "*";
                            k = "+";
                            result = c * d + c;
                            break;
                        case 9:
                            g = "*";
                            k = "-";
                            result = c * d - c;
                            break;
                        case 10:
                            g = "*";
                            k = "*";
                            result = c * d * c;
                            break;
                        case 11:
                            g = "*";
                            k = "/";
                            result = c * d / c;
                            break;
                        case 12:
                            g = "/";
                            k = "+";
                            result = c / d + c;
                            break;
                        case 13:
                            g = "/";
                            k = "-";
                            result = c / d - c;
                            break;
                        case 14:
                            g = "/";
                            k = "*";
                            result = c / d * c;
                            break;
                        case 15:
                            g = "/";
                            k = "/";
                            result = c / d / c;
                            break;
                    }
                    
                    Console.WriteLine(c + g + d + k + m + "=" + result);
               
                }
                else
                {
                    n = n + 1;
                }
               if (result <0)
                {
                    n = n + 1;
                }
            }
           
            Console.ReadKey();
        }
    }

    }
