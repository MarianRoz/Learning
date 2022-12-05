using System;
namespace _2Essential.TasksClass
{
//    Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте класс AbstractHandler.
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.


    abstract class AbstractHandler
    {
        //add
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        { Console.WriteLine("XML open"); }
        public override void Create()
        { Console.WriteLine("XML create"); }
        public override void Chenge()
        { Console.WriteLine("XML chenge"); }
        public override void Save()
        { Console.WriteLine("XML save"); }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        { Console.WriteLine("TXT open"); }
        public override void Create()
        { Console.WriteLine("TXT create"); }
        public override void Chenge()
        { Console.WriteLine("TXT chenge"); }
        public override void Save()
        { Console.WriteLine("TXT save"); }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        { Console.WriteLine("DOC open"); }
        public override void Create()
        { Console.WriteLine("DOC create"); }
        public override void Chenge()
        { Console.WriteLine("DOC chenge"); }
        public override void Save()
        { Console.WriteLine("DOC save"); }
    }
}