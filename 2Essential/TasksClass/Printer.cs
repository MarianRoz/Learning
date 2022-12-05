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

    public class Printer
    {
        public virtual void Print(string valuePrinter1)
        {
            Console.WriteLine(valuePrinter1);
        }
    }
    public class PrinterRed : Printer
    {
        public override void Print(string valuePrinter2)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(valuePrinter2);//base.Print(valuePrinter2);
            Console.ResetColor();
        }
    }
    public class PrinterYellow : Printer
    {
        public override void Print(string valuePrinter2)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(valuePrinter2);//base.Print(valuePrinter2);
            Console.ResetColor();
        }
    }
    public class PrinterGreen : Printer
    {
        public override void Print(string valuePrinter2)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(valuePrinter2);//base.Print(valuePrinter2);
            Console.ResetColor();
        }
    }
    public class PrinterBlack
    {
        private void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private void PrintValue(string valuePrinter2)
        {
            Console.WriteLine(valuePrinter2);
        }
        private void ResetColor()
        {
            Console.ResetColor();
        }
        /// <summary>
        /// Print text with black Background
        /// </summary>
        /// <param name="valuePrinter2"></param>
        public void Print(string valuePrinter2)
        {
            SetBackgroundColor();
            PrintValue(valuePrinter2);
            ResetColor();
        }
    }
}
