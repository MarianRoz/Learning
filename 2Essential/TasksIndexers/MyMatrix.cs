using System;
namespace _2Essential.TasksIndexers
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера
    //с возможностью изменения числа строк и столбцов.
    //Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.

    public class MyMatrix
    {
        private int[,] matrix = null;

        private int numberOfCols;
        private int numberOfRows;

        public int NumberOfCols
        {
            get { return numberOfCols; }
        }
        public int NumberOfRows
        {
            get { return numberOfRows; }
        }

        public MyMatrix()
        {
        }

        public MyMatrix(int numberOfCols, int numberOfRows)
        {
            if (numberOfCols < 0 || numberOfRows < 0)
            {
                Console.WriteLine("Значення не можуть бути негативним");
            }
            else
            {
                this.numberOfCols = numberOfCols;
                this.numberOfRows = numberOfRows;
                matrix = new int[numberOfCols, numberOfRows];
            }
        }

        public void ChangeMatrix(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                Console.WriteLine("Значення не можуть бути негативним");
            }
            else
            {
                this.numberOfCols = x;
                this.numberOfRows = y;
                matrix = new int[numberOfCols, numberOfRows];
            }
        }

        public void FeedMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    matrix[i, j] = rand.Next(30, 99);
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int col, int row]
        {
            set
            {
                if ((col > 0 && row > 0) && (col < numberOfCols && row < numberOfRows))
                    matrix[col, row] = value;
                else
                    Console.WriteLine("Недопустиме значення індексів {0} и {1}", col, row);
            }
            get
            {
                return matrix[col, row];
            }
        }
    }
}