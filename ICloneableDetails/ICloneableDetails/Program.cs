using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICloneableDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20, "MyCar1");
            Console.WriteLine(p1);
            Point p2 = (Point)p1.Clone();
            Console.WriteLine(p2);
            
            p2.X = 30;
            p2.PD.PetName = "MyCar2";
            Console.WriteLine(p2);
            Console.WriteLine(p1);
            Console.ReadLine();
        }
    }
    class Point :ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription PD = new PointDescription();
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            PD.PetName = name;

        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point() { }

        public override string ToString()
        {
            return string.Format("X = {0},Y ={1}, PetName = {2},GUID = {3}", X, Y,PD.PetName,PD.PointID);
        }

        public object Clone()
        {
            Point newPoint = new Point();
            newPoint.X = this.X;
            newPoint.Y = this.Y;
            newPoint.PD.PetName = this.PD.PetName;
            return newPoint;

        }
    }

    class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }

        public PointDescription()
        {
            PetName = "NoName";
            PointID = Guid.NewGuid();
        }
    }
}
