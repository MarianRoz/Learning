using System;
using Essential.Tasks;
using static Essential.Tasks.Program;

namespace Essential
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Address example = new Address();
            example.Index = 36000;
            example.Country = "Ukraina";
            example.City = "Ivano-Frankivsk";
            example.Street = "Halitska";
            example.House = 102;
            example.Apartment = 247;
            Console.WriteLine($"Index - {example.index} \nCountry - {example.country} \nCity - {example.city} \nStreet - {example.street} \nHouse - {example.house} \nApartment - {example.apartment}");


            var rectangle = new Rectangle(6.4, 3.8);
            Console.WriteLine($"Area - {rectangle.Area}, Perimetr - {rectangle.Perimeter}");

            Book book = new Book()
            {
                Title = new Title(),
                Author = new Author(),
                Content = new Content()
            };
            book.Show();
            Console.ReadLine();

            Figure cube = new Figure("cube");
            Console.WriteLine(cube.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
