using System;
namespace Essential.Tasks
{
    class Point
    {
        string name;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Point() : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            this.name = "Marian";
            this.x = 4;
            this.y = 3;
        }
    }

    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("enter number of verticles of your figure");
            number = 5;
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }


}

//public class Ptoperty
//{
//    public double LengthSide(Point A, Point B)
//    {
//        int result = A.a1;
//        return result;
//    }

//    public void PerimetrCalculator(Figure a1,Figure a2)
//    {
//        int resultPerimetr = a1 + a2;
//    }

//}
//public class Point
//{
//    public int a1, a2;
//    public string b1;

//    public Point Property1 { get; }
//    public Point Property2 { get; }
//    public Point Property3 { get; }
//}

//public class Figure
//{
//    public Figure(int a1,int a2, string b1)
//    {
//        a1 = 2;
//        a2 = 3;
//        b1 = "Polygon";
//    }
//}