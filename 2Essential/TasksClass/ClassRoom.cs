using System;
namespace _2Essential.TasksClass
{
    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс, представляющий учебный класс ClassRoom.
    //Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
    //Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
    //Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
    //Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
    partial class ClassRoom
    {
        Pupil[] arrPupil; //масив учнів

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4) // якщо 4 учня
        { arrPupil = new Pupil[] { p1, p2, p3, p4 }; } 

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3) // якщо 3 учня
        { arrPupil = new Pupil[] { p1, p2, p3 }; } 

        public ClassRoom(Pupil p1, Pupil p2) // якщо 2 учня
        { arrPupil = new Pupil[] { p1, p2 }; }

        public void InfoStudy()
        {
            Console.WriteLine("Study: ");
            foreach (Pupil item in arrPupil)
            { item.Study(); }
        }
        public void InfoRead()
        {
            Console.WriteLine("Read: ");
            foreach (Pupil item in arrPupil)
            { item.Read(); }
        }
        public void InfoWrite()
        {
            Console.WriteLine("Write: ");
            foreach (Pupil item in arrPupil)
            { item.Write(); }
        }
        public void InfoRelax()
        {
            Console.WriteLine("Relax: ");
            foreach (Pupil item in arrPupil)
            { item.Relax(); }
        }
    }

    partial class ExcelentPupil : Pupil
    {
        public override void Study()
        {Console.WriteLine("ExcelentPupil: Study-exceletn");}

        public override void Read()
        {Console.WriteLine("ExcelentPupil: Read-exceletn");}

        public override void Write()
        {Console.WriteLine("ExcelentPupil: Write-exceletn");}

        public override void Relax()
        {Console.WriteLine("ExcelentPupil: Relax-exceletn");}
    }
    partial class GoodPupil : Pupil
    {
        public override void Study()
        {Console.WriteLine("GoodPupil: Study-Good");}

        public override void Read()
        {Console.WriteLine("GoodPupil: Read-Good");}

        public override void Write()
        {Console.WriteLine("GoodPupil: Write-Good");}

        public override void Relax()
        {Console.WriteLine("GoodPupil: Relax-Good");}
    }
    partial class BadPupil : Pupil
    {
        public override void Study()
        {Console.WriteLine("BadPupil: Study-Bad");}

        public override void Read()
        {Console.WriteLine("BadPupil: Read-Bad");}

        public override void Write()
        {Console.WriteLine("BadPupil: Write-Bad");}

        public override void Relax()
        {Console.WriteLine("BadPupil: Relax-Bad");}
    }

    partial class Pupil
    {
        public virtual void Study()
        { }
        public virtual void Read()
        { }
        public virtual void Write()
        { }
        public virtual void Relax()
        { }
    }
}
