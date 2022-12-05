using System;
namespace _2Essential.TasksClass
{
//Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Invoice.
//В теле класса создать три поля int account, string customer, string provider которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

    public partial class Invoice
    {
        readonly int account = 1; //рахунок
        readonly string customer = "Marian"; // клієнт
        readonly string provider= "Nike"; // провайдер(продавець)

        private string article; // артикуль товару
        private int quantity; //  кількість товару

        public int paymentAmount;
        public int PaymentAmount //свойство
        {
            set { paymentAmount = value; }
            get { return paymentAmount; }
        }

        public string Article //свойство
        {
            set { article = value; }
            get { return article; }
        }
        public int Quantity //свойство
        {
            set { quantity = value; }
            get { return quantity; }
        }

        public Invoice()
        {
            Console.WriteLine("Введіть артикуль товару");
            Article = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть кількість товару");
            Quantity = Convert.ToInt32(Console.ReadLine());

            if (article=="1")
            paymentAmount = 300;

            if (article=="2")
            paymentAmount = 400;
            
            if (article=="3")
            paymentAmount = 500;

            if (article != "1" && article != "2" && article != "3")
            Console.WriteLine("Ви ввели неіснуючий артикуль");
        }
    }
}
