using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(5, 10);
            Point p3 = p1 + p2;
            Console.WriteLine(p3);
            Point p4 = p1 - p2;
            Console.WriteLine(p4);
            Point p5 = p1 + 5;
            Console.WriteLine(p5);


            Console.ReadKey();
                 
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("Value of x is {0} and y is {1}",X,Y);
        }

        public static Point operator +(Point pt1, Point pt2)
        {
            return new Point(pt1.X + pt2.X, pt1.Y + pt2.Y);
        }

        public static Point operator -(Point pt1, Point pt2)
        {
            return new Point(pt1.X - pt2.X, pt1.Y - pt2.Y);
        }

        public static Point operator +(Point pt1, int change)
        {
            return new Point(pt1.X + change, pt1.Y + change); //Not required that both the parameters are of the same type
        }
    }
}
