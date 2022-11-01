using System;
/// <summary>
/// Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс с именем Address. Втелеклассатребуетсясоздатьполя:index,country,city,street,house,apartment.Длякаждого поля, создать свойство с двумя методами доступа.
//Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.
/// </summary>
namespace Essential.Tasks
{
    public partial class Address
    {
        public int index;
        public int Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }

        public string country;
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }

        public string city;
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }

        public string street;
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }

        public int house;
        public int House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }

        public int apartment;
        public int Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }

    }
}
