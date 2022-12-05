using System;
namespace _2Essential.TasksClass
{
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Employee.
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
//Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.

    public partial class Employee
    {
        string name;
        string surname;
        string positions;  //посада
        double salary;   //оклад
        double experience; //стаж
        double tax; //податок

        public string Name //свойство
        {
            set { name = value; }
            get { return name; }
        }
        public string Surname //свойство
        {
            set { surname = value; }
            get { return surname; }
        }
        public string Positions //свойство
        {
            set { positions = value; }
            get { return positions; }
        }
        public double Salary //свойство
        {
            set { salary = value; }
            get { return salary; }
        }
        public double Experience //свойство
        {
            set { experience = value; }
            get { return experience; }
        }
        public double Tax //свойство
        {
            set { tax = value; }
            get { return tax; }
        }

        public Employee()
        {
        }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
}
