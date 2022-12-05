using System;
using System.Linq;
namespace _2Essential.TasksIndexers
{
    //Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Article, содержащий следующие закрытые поля:
    //• название товара;
    //• название магазина, в котором продается товар;
    //• стоимость товара в гривнах.
    //Создать класс Store, содержащий закрытый массив элементов типа Article.
    //Обеспечить следующие возможности:
    //• вывод информации о товаре по номеру с помощью индекса;
    //• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение;
    //Написать программу, вывода на экран информацию о товаре.


    public class Article
    {
        public string Name { get; private set; }
        public string Shop { get; private set; }
        public double Cost { get; private set; }
        public Article(string name, string shop, double cost)
        {
            Name = name;
            Shop = shop;
            Cost = cost;
        }
        public override string ToString()
        {
            return $"назва: {Name}, магазин: {Shop}, ціна: {Cost}";
        }
        public static double operator +(Article obj1, Article obj2)
        {
            return obj1.Cost + obj2.Cost;
        }
    }
    class Stock
    {
        Article[] products;
        public int Length { get; private set; }
        public Stock(int length)
        {
            Length = length;
            products = new Article[Length];
        }
        public Article this[int index]
        {
            get
            {
                if (IsValid(index))
                    return products[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (IsValid(index))
                    products[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public Article FindProduct(string name)
        {
            foreach (Article item in products)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }
        public Article[] SortByName()
        {
            return products.OrderBy(n => n.Name).ToArray();
        }
        public Article[] SortByShop()
        {
            return products.OrderBy(n => n.Shop).ToArray();
        }
        public Article[] SortByCost()
        {
            return products.OrderBy(n => n.Cost).ToArray();
        }
        private bool IsValid(int index)
        {
            return (index >= 0) && (index < Length);
        }
    }
}