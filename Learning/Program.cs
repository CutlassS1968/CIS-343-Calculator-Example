using System;

namespace Learning
{
    class Program
    {
        private Student student;
        static void Main(string[] args)
        {
            Program program = new Program();
        }

        public Program()
        {
            student = new Student();
            System.Console.WriteLine(student.getNumber());

            student.setNumber(1);
            System.Console.WriteLine(student.getNumber());
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

        public static float pow(float a, float p)
        {
            float res = a;
            if (p > 0)
            {
                for (int i = 1; i < p; i++)
                {
                    res *= res;
                }
            }
            else if (p < 0)
            {

            }
            else if (p == 0)
            {

            }
            return res;
        }
    }
}
