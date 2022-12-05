using System;
namespace _2Essential.TasksClass
//    Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также программа должна производить конвертацию из указанных валют в гривну.


{
    public partial class Converter
    {
        public Converter(double usd, double eur, double gpb)
        {
            this.usd = usd;
            this.eur = eur;
            this.gpb = gpb;
        }

        double result = 0;
        double getting;
        double usd;
        double eur;
        double gpb;

        public double Getting()  //отримане число грошей
        { return getting; }
        public double GetUsd()  //курс долара
        { return usd;}
        public double GetEur() //курс євро
        {return eur;}
        public double GetGpb() //курс фунта
        { return gpb; }
        
        internal double ConvecterGrnInOtherMoney()
        {
            Console.WriteLine("Enter the amount(grn):");
            getting = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose a currency: 1 - usd, 2 - eur, 3 - gpb");
            int get = Convert.ToInt32(Console.ReadLine());
            if (get == 1) 
            {
                result = getting / usd;
            }
            if (get == 2) 
            {
                result = getting / eur;
            }
            if (get == 3) 
            {
                result = getting / gpb;
            }
            if(result == 0)
            {
                Console.WriteLine("Ви ввели неправильне значення. Спробуйте ще раз.");
                ConvecterGrnInOtherMoney();
            }
            return result;
        }
        internal double ConvecterOtherMoneyInGrn()
        {
            Console.WriteLine("Enter the amount(usd/eur/gpb):");
            getting = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select the currency to convert: 1 - usd, 2 - eur, 3 - gpb");
            int get = Convert.ToInt32(Console.ReadLine());
            if (get == 1)
            {
                result = getting * usd;
            }
            if (get == 2)
            {
                result = getting * eur;
            }
            if (get == 3)
            {
                result = getting * gpb;
            }
            if (result == 0)
            {
                Console.WriteLine("Ви ввели неправильне значення. Спробуйте ще раз.");
                ConvecterOtherMoneyInGrn();
            }
            return result;
        }


    }
}
