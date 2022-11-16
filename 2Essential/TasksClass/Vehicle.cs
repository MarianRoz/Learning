using System;
namespace _2Essential.TasksClass
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Vehicle.
    //В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
    //Создайте 3 производных класса Plane, Саг и Ship.
    //Для класса Plane должна быть определена высота и количество пассажиров.
    //Для класса Ship — количество пассажиров и порт приписки.
    //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.


    internal class Vehicle
    {
        private double coordinateX, coordinateY;
        private double price, speed, year;

        public double CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Year
        {
            get { return year; }
            set { year = value; }
        }

        public void Coordinate(double CoordinateX, double CoordinateY)
        {
            this.CoordinateX = CoordinateX;
            this.coordinateY = CoordinateY;
        }

        public void SpeedMethod(double Speed)
        {
            this.Speed = Speed;
        }
    }

    class Plane : Vehicle
    {
        public double Height { get; set; }
        public double NumberOfPassengers { get; set; }
    }

    class Ship : Vehicle
    {
        public double NumberOfPassengers { get; set; }
        public string DestinationPort { get; set; }
    }
}