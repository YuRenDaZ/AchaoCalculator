using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class Calculator 
{
    private static string[] op = new string[] { "+", "-", "*", "/" }; //初始化运算符
    public static void Main(string[] args)
    {
        Console.Write("请输入生成的四则运算表达式的个数：");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string question = makequestion();
            Console.WriteLine(question);
            string a = Solve(question);
            Console.WriteLine(question + "=" + a);  
        }
        Console.Read();
    }
    //生成表达式
    public static string makequestion()
    {
        Random r = new Random(Guid.NewGuid().GetHashCode());//解决随机数重复的问题
        StringBuilder build = new StringBuilder();
        int count = r.Next(1,4); // 运算符个数
        int start = 0;
        int number1 = r.Next(1,100);
        build.Append(number1);
        while (start <= count)
        {
            int operation = r.Next(1,4); // 随机运算符
            int number2 = r.Next(1,100);
            build.Append(op[operation]).Append(number2);
            start++;
        }
        return build.ToString();
    }
    //计算四则运算表达式结果
    public static string Solve(string question)
    {
        DataTable dt = new DataTable();
        string answer = dt.Compute(question, null).ToString();
        return answer;
    }
}
