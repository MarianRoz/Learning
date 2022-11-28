using System;
namespace _2Essential.TasksClass
{
    public static class Calculator
    {
        public static double a;
        public static double b;

        public static void Addition()
        {
            Console.WriteLine(a + b);
        }
        public static void Subtraction()
        {
            Console.WriteLine(a - b);
        }
        public static void Multiplication()
        {
            Console.WriteLine(a * b);
        }
        public static void Division()
        {
            Console.WriteLine(a / b);
        }
    }
}
