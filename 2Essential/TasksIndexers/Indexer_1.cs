using System;
namespace _2Essential.TasksIndexers
{
    // Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    //Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.

    public partial class BaseClassIndexer
    {
        public int[] nArray = null;
        public BaseClassIndexer()
        {
            nArray = new int[5];
            nArray[0] = 4;
            nArray[1] = 7;
            nArray[2] = 10;
            nArray[3] = 17;
            nArray[4] = 11;
        }
        public int this[int index]
        {
            get {return nArray[index];}
            set {nArray[index] = value;}
        }

        public void MaxValueIndexer()
        {
            int max = 0;
            for (int i = 0; i < nArray.Length; i++)
            {
                if (max < nArray[i])
                {
                    max = nArray[i];
                }
            }
            Console.WriteLine(max);
        }
        public void MinValueIndexer()
        {
            int min = nArray[0];
            for (int i = 0; i < nArray.Length; i++)
            {
                if (min > nArray[i])
                {
                    min = nArray[i];
                }
            }
            Console.WriteLine(min);
        }
        public void TotalNumberIndexers()
        {
            int total = 0;
            for (int i = 0; i < nArray.Length; i++)
            {
                total += nArray[i];
            }
            Console.WriteLine(total);
        }
        public void ArithmeticMean()
        {
            double arithmeticMean = 0;
            for (int i = 0; i < nArray.Length; i++)
            {
                arithmeticMean += nArray[i];
            }
            Console.WriteLine(arithmeticMean / nArray.Length);
        }
        public void OddValues()
        {
            for (int i = 0; i < nArray.Length; i++)
            {
                if (nArray[i] % 2 != 0)
                {
                    Console.Write("{0} ", nArray[i]);
                }
            }
        }
    }
}