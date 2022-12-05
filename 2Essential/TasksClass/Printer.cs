using System;
namespace _2Essential.TasksClass
{
//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте класс Printer.
//В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
//Обязательно используйте приведение типов.

    partial class Printer
    {
        public virtual void Print(string valuePrinter1)
        {
            Console.WriteLine(valuePrinter1);
        }
    }
    partial class PrinterRed : Printer
    {
        public override void Print(string valuePrinter2)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            base.Print(valuePrinter2);
            Console.ResetColor();
        }
    }
}
