//// See https://aka.ms/new-console-template for more information

//using System;

//namespace lab1
//{
//    public class Rectangle1
//    {
//        private double side1, side2;
//        public Rectangle1(double sideA, double sideB)
//        {
//            side1 = sideA;
//            side2 = sideB;
//        }

//        private double CalculateArea()
//        {
//            return side1 * side2;
//        }
//        private double CalculatePerimeter()
//        {
//            return 2 * (side1 + side2);

//        }
//        public double Area
//        {
//            get
//            {
//                return CalculateArea();

//            }
//        }
//        public double Perimeter
//        {
//            get
//            {
//                return CalculatePerimeter();
//            }
//        }
//        static void Main()
//        {
//            Console.WriteLine("№1");
//            Console.WriteLine("Byte " + "Max:" + System.Byte.MaxValue + " Min:" + System.Byte.MinValue);
//            Console.WriteLine("SByte " + "Max:" + System.SByte.MaxValue + " Min:" + System.SByte.MinValue);
//            Console.WriteLine("Int16 " + "Max:" + System.Int16.MaxValue + " Min:" + System.Int16.MinValue);
//            Console.WriteLine("Int64 " + "Max:" + System.Int64.MaxValue + " Min:" + System.Int64.MinValue);
//            Console.WriteLine("Decimal " + "Max:" + System.Decimal.MaxValue + " Min:" + System.Decimal.MinValue);
//            Console.WriteLine("Single " + "Max:" + System.Single.MaxValue + " Min:" + System.Single.MinValue);

//            Console.WriteLine("№2");
//            Console.WriteLine("Enter side1");
//            double side1 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter side2");
//            double side2 = Convert.ToDouble(Console.ReadLine());
//            Rectangle1 Figure = new Rectangle1(side1, side2);
//            Console.WriteLine("Perimeter: " + Figure.Perimeter);
//            Console.WriteLine("Area: " + Figure.Area);
//        }
//    }
//}