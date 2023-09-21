using System;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace ConsoleApp1
{

    public class Point
    {
        private double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }
    }
    public class Figure
    {
        private string name;
        private Point[] points;
        private int amount;

        //Triangle
        public Figure(int amount, Point A, Point B, Point C)
        {
            this.amount = amount;
            points = new Point[5];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            name = "Triangle";
        }
        //Rectangle
        public Figure(int amount, Point A, Point B, Point C, Point D) : this(amount, A, B, C)
        {
            points[3] = D;
            name = "Rectangle";
        }
        //Pentagon
        public Figure(int amount, Point A, Point B, Point C, Point D, Point E) : this(amount, A, B, C, D)
        {
            points[4] = E;
            name = "Pentagon";
        }
        private double LengthSide(Point A, Point B)
        {

            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }
        private double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < amount - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[amount - 1], points[0]);
            return perimeter;
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of points: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate x for point A: ");
            double x_a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point A: ");
            double y_a = Convert.ToDouble(Console.ReadLine());
            Point A = new Point(x_a, y_a);
            Console.WriteLine("Enter coordinate x for point B: ");
            double x_b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point B: ");
            double y_b = Convert.ToDouble(Console.ReadLine());
            Point B = new Point(x_b, y_b);
            Console.WriteLine("Enter coordinate x for point C: ");
            double x_c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point C: ");
            double y_c = Convert.ToDouble(Console.ReadLine());
            Point C = new Point(x_c, y_c);
            if (amount == 3)
            {
                Figure triangle = new Figure(amount, A, B, C);
                Console.WriteLine(triangle.Name + " perimeter: " + triangle.Perimeter);
            }
            else
            {
                if (amount > 3)
                {
                    Console.WriteLine("Enter coordinate x for point D: ");
                    double x_d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter coordinate y for point D: ");
                    double y_d = Convert.ToDouble(Console.ReadLine());
                    Point D = new Point(x_d, y_d);
                    if (amount == 4)
                    {
                        Figure Rectangle = new Figure(amount, A, B, C, D);
                        Console.WriteLine(Rectangle.Name + " perimeter: " + Rectangle.Perimeter);
                    }
                    if (amount == 5)
                    {
                        Console.WriteLine("Enter coordinate x for point E: ");
                        double x_e = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter coordinate y for point E: ");
                        double y_e = Convert.ToDouble(Console.ReadLine());
                        Point E = new Point(x_c, y_c);
                        Figure Pentagon = new Figure(amount, A, B, C, D, E);
                        Console.WriteLine(Pentagon.Name + " perimeter: " + Pentagon.Perimeter);
                    }
                }
            }
        }
    }
}
