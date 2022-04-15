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

    class Student
    {
        private int number;
        public Student()
        {
            number = 0;
        }

        public int getNumber()
        {
            return number;
        }

        public void setNumber(int number)
        {
            this.number = number;
        }
    }
}
