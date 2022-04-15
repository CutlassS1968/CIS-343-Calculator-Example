using System;

namespace Learning
{
    class Program
    {
        private Calculator calculator;
        static void Main(string[] args)
        {
            Program program = new Program();
        }

        public Program()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string op = Console.ReadLine();

            float res = 0;

            switch (op)
            {
                case '+':
                    res = Calculator.add(a, b);
                    break;
                case '-':
                    res = Calculator.sub(a, b);
                    break;
                case '*':
                    res = Calculator.mul(a, b);
                    break;
                case '/':
                    res = Calculator.div(a, b);
                    break;
                case '**':
                    res = Calculator.pow(a, b);
            }

            Console.WriteLine(res);
        }
    }

    class Calculator
    {
        public static float add(float a, float b)
        {
            return a + b;
        }

        public static float sub(float a, float b)
        {
            return a - b;
        }

        public static float mul(float a, float b)
        {
            return a * b;
        }

        public static float div(float a, float b)
        {
            return a / b;
        }

        public static float pow(float a, float n)
        {
            float res = a;
            if (n % 2 == 0)
            {
                int exp = n / 2;
                res = (a * a);
                for (int i = 1; i < exp; i++)
                {
                    res *= res;
                }
            }
            else
            {
                int exp = (n - 1) / 2;
                int res = (a * a);
                for (int i = 1; i < exp; i++)
                {
                    res *= res;
                }
                res = a * res; 
            }
            return res;
        }
    }
}
