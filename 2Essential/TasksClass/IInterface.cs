using System;
namespace _2Essential.TasksClass
{
//    Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
//Создайте производный класс Playerот базовых интерфейсов IPlayable и IRecodable.
//Написать программу, которая выполняет проигрывание и запись.

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class BaseClassPlayable : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Play in Playable");
        }
        public void Pause()
        {
            Console.WriteLine("Pause in Playable");
        }
        public void Stop()
        {
            Console.WriteLine("Stop in Playable");
        }
    }
    class BaseClassRecodable : IRecodable
    {
        public void Record()
        {
            Console.WriteLine("Record in Recodable");
        }
        public void Pause()
        {
            Console.WriteLine("Pause in Recodable");
        }
        public void Stop()
        {
            Console.WriteLine("Stop in Recodable");
        }
    }
}
