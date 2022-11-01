using System;
namespace Essential.Tasks
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется: Создать класс с именем Rectangle.
    //В теле класса создать два поля, описывающие длины сторон.
    //Создать пользовательский конструктор Rectangle(double side1, double side2)Rectangle(double side1, double side2) в теле которого
    //поля side1 и side2 инициализируются значениями аргументов.
    //Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
    //Создать два свойства double Area и double Perimeter с одним методом доступа get.
    //Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
    public partial class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double AreaCalculator()
        {
            return side1 * side2;
        }
        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
}
