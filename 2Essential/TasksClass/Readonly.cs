using System;
namespace _2Essential.TasksClass
{
// Задание
// Используя Visual Studio, создайте проект по шаблону Console Application.
// Требуется:
// Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты).
// Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
// Реализуйте вывод на экран информации о пользователе.

    public partial class User
    {
        string login, name, surname;
        int age;
        readonly DateTime date = DateTime.Now;

        public string Login //свойство
        {
            set { login = value; }
            get { return login; }
        }

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

        public int Age //свойство
        {
            set { age = value; }
            get { return age; }
        }
    }
}