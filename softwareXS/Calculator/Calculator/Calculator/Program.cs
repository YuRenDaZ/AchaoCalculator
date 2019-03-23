using System;

namespace Calculator
{
    public class progrem
    {
        public static void Main()
        {
            Cal c = new Cal();
            c.exercise(10);
            Console.ReadKey();
        }
    }
    
    public class Cal
    {
        public static double DoExercose(double a,double b,string c)
        {
            switch (c)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
            }
            return 0;
        }
        public void exercise(int n)
        {
            int a = 1, b = 1, c = 1;
            double result1 = 0,result2=0;
            string s = "";
            string[] symbol = { "+", "-","*","/" };
            Random rd = new Random();
            for(int i = 0; i < n; i++)
            {
                a = rd.Next(1, 100);
                b = rd.Next(1, 100);
                c = rd.Next(1,100);
                if (i % 2 == 0) {
                    if ((result1=DoExercose(a,b,symbol[i%4]))!=0)
                    {
                        result2 = DoExercose(result1, c, symbol[(i+1) % 4]);
                    }
                    
                    Console.Write(a + symbol[i % 4] + b + symbol[(i + 1) % 4] + c + " ="+result2);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }

        
}
