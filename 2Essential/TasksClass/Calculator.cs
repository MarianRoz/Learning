using System;
namespace _2Essential.TasksClass
{
//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
//Написать программу, которая выводит на экран основные арифметические операции.

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