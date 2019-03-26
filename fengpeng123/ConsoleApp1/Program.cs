using System;
namespace ConsoleApp1
{
    public class chansheng//产生随机数
    {
        public int shengcheng()
        {
            Random ran = new Random();
            int h = ran.Next(0, 101);//产生0到100之间的随机数，并将它返回到主函数中的数组里去
            return h;

        }
        public double yunshuan(double x, char y, double z)//将相邻的两个数进行运算。
        {
            switch (y)
            {
                case '+':
                    return x + z;
                case '-':
                    return x - z;
                case '*':
                    return x * z;
                default:
                    return x / z;

            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("用户输入题的数目n");
            int n = int.Parse(Console.ReadLine());//用户输入题目数


            for (int i = 0; i < n; i++)//产生题目的个数
            {
                Random ran = new Random();
                int key = ran.Next(3, 5);//先随机产生每道题的中数字的个数


                int[] shuzi = new int[key];//数字数组

                chansheng A = new chansheng();
                for (int j = 0; j < key; j++)//调用方法，产生数组中的值
                {
                    shuzi[j] = A.shengcheng();
                }
                char[] fuhao = { '+', '-', '*', '/' };
                char[] fuhao1 = new char[key - 1];//重新命名一个字符数组对应随机产生的字符
                for (int j = 0; j < key - 1; j++)
                {
                    fuhao1[j] = fuhao[new Random(Guid.NewGuid().GetHashCode()).Next(0, 4)];//随机产生字符数组的下标
                }



                if (key == 3)//当一道题中的数字为3个时
                {

                    chansheng B = new chansheng();
                    Double p;
                    if (fuhao1[0] == '*' || fuhao1[0] == '/')//当第一个运算符是*或者/的时候，先把前两个数算出来
                    {
                        double o = B.yunshuan(shuzi[0], fuhao1[0], shuzi[1]);
                        p = B.yunshuan(o, fuhao1[1], shuzi[2]);//再把之前的结果和后面剩下的一个数进行运算

                        if (p < 0)
                        {
                            i = i - 1;
                            continue;   //这里考虑的是最后结果是负数或者是有小数，就停止当前循环，然后把题的数目减个1
                        }                  //就是舍去这道题，重新出一道

                        string p1 = p.ToString();
                        if (p1.Contains(".") == true)
                        {
                            i = i - 1;
                            continue;
                        }
                        Console.WriteLine(shuzi[0] + "" + fuhao1[0] + "" + shuzi[1] + "" + fuhao1[1] + "" + shuzi[2] + "=" + p);

                    }
                    else
                    {
                        if (fuhao1[1] == '*' || fuhao1[1] == '/')//当第二个运算符是*或者/的时候，先把后两个数算出来
                        {
                            double o = B.yunshuan(shuzi[1], fuhao1[1], shuzi[2]);
                            p = B.yunshuan(shuzi[0], fuhao1[0], o);//再把第一个数进行运算
                            if (p < 0)
                            {
                                i = i - 1;
                                continue;
                            }                    //和之前一样的判断

                            string p1 = p.ToString();
                            if (p1.Contains(".") == true)
                            {
                                i = i - 1;
                                continue;
                            }

                            Console.WriteLine(shuzi[0] + "" + fuhao1[0] + "" + shuzi[1] + "" + fuhao1[1] + "" + shuzi[2] + "=" + p);
                        }
                        else//不含乘除，依次运算
                        {
                            double o = B.yunshuan(shuzi[0], fuhao1[0], shuzi[1]);
                            p = B.yunshuan(o, fuhao1[1], shuzi[2]);
                            if (p < 0)
                            {
                                i = i - 1;
                                continue;
                            }
                            //相同判断
                            string p1 = p.ToString();
                            if (p1.Contains(".") == true)
                            {
                                i = i - 1;
                                continue;
                            }

                            Console.WriteLine(shuzi[0] + "" + fuhao1[0] + "" + shuzi[1] + "" + fuhao1[1] + "" + shuzi[2] + "=" + p);
                        }
                    }

                }// 输出结果

                if (key == 4)//当一道题中的数字为4个时
                {
                    chansheng M = new chansheng();
                    double p;
                    if (fuhao1[2] == '*' || fuhao1[2] == '/')//单纯考虑最后一个运算符是不是乘或者除，如果是的话
                    {
                        double k = M.yunshuan(shuzi[2], fuhao1[2], shuzi[3]);//先把最后两个数算出来,作为一个结果k
                        chansheng B = new chansheng();




                        if (fuhao1[0] == '*' || fuhao1[0] == '/')//之后的就和之前三个数一样的方式了，就是把k看成第3个数
                        {
                            double o = B.yunshuan(shuzi[0], fuhao1[0], shuzi[1]);
                            p = B.yunshuan(o, fuhao1[1], k);
                            if (p < 0)
                            {
                                i = i - 1;
                                continue;
                            }

                            string p1 = p.ToString();
                            if (p1.Contains(".") == true)
                            {
                                i = i - 1;
                                continue;
                            }
                            Console.WriteLine(shuzi[0] + "" + fuhao1[0] + " " + shuzi[1] + "" + fuhao1[1] + "" + shuzi[2] + "" + fuhao1[2] + "" + shuzi[3] + "=" + p);


                        }
                        else
                        {
                            if (fuhao1[1] == '*' || fuhao1[1] == '/')
                            {
                                double o = B.yunshuan(shuzi[1], fuhao1[1], k);
                                p = B.yunshuan(shuzi[0], fuhao1[0], o);
                                if (p < 0)
                                {
                                    i = i - 1;
                                    continue;
                                }

                                string p1 = p.ToString();
                                if (p1.Contains(".") == true)
                                {
                                    i = i - 1;
                                    continue;
                                }
                                Console.WriteLine(shuzi[0] + "" + fuhao1[0] + " " + shuzi[1] + "" + fuhao1[1] + "" + shuzi[2] + "" + fuhao1[2] + "" + shuzi[3] + "=" + p);

                            }
                            else
                            {
                                double o = B.yunshuan(shuzi[0], fuhao1[0], shuzi[1]);
                                p = B.yunshuan(o, fuhao1[1], k);
                                if (p < 0)
                                {
                                    i = i - 1;
                                    continue;
                                }

                                string p1 = p.ToString();
                                if (p1.Contains(".") == true)
                                {
                                    i = i - 1;
                                    continue;
                                }
                                Console.WriteLine(shuzi[0] + "" + fuhao1[0] + " " + shuzi[1] + "" + fuhao1[1] + "" + shuzi[2] + "" + fuhao1[2] + "" + shuzi[3] + "=" + p);

                            }
                        }

                    }



                    else//如果最后一个运算符是加或者减，先把之前3个数的算完了，在和第四个数进行运算。
                    {
                        chansheng B = new chansheng();
                        Double q;
                        if (fuhao1[0] == '*' || fuhao1[0] == '/')
                        {
                            double o = B.yunshuan(shuzi[0], fuhao1[0], shuzi[1]);
                            q = B.yunshuan(o, fuhao1[1], shuzi[2]);
                            if (q < 0)
                            {
                                i = i - 1;
                                continue;
                            }

                            string p1 = q.ToString();
                            if (p1.Contains(".") == true)
                            {
                                i = i - 1;
                                continue;
                            }


                        }
                        else
                        {
                            if (fuhao1[1] == '*' || fuhao1[1] == '/')
                            {
                                double o = B.yunshuan(shuzi[1], fuhao1[1], shuzi[2]);
                                q = B.yunshuan(shuzi[0], fuhao1[0], o);
                                if (q < 0)
                                {
                                    i = i - 1;
                                    continue;
                                }

                                string p1 = q.ToString();
                                if (p1.Contains(".") == true)
                                {
                                    i = i - 1;
                                    continue;
                                }

                            }
                            else
                            {
                                double o = B.yunshuan(shuzi[0], fuhao1[0], shuzi[1]);
                                q = B.yunshuan(o, fuhao1[1], shuzi[2]);
                                if (q < 0)
                                {
                                    i = i - 1;
                                    continue;
                                }

                                string p1 = q.ToString();
                                if (p1.Contains(".") == true)
                                {
                                    i = i - 1;
                                    continue;
                                }
                            }
                        }
                        p = B.yunshuan(q, fuhao1[2], shuzi[3]);
                        if (p < 0)
                            continue;
                        Console.WriteLine(shuzi[0] + "" + fuhao1[0] + " " + shuzi[1] + "" + fuhao1[1] + "" + shuzi[2] + "" + fuhao1[2] + "" + shuzi[3] + "=" + p);
                    }
                }//输出结果

            }

        }
    }
}

