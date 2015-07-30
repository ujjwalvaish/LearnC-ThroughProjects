using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomTypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5,3);
            Square s = new Square(4);
            Console.WriteLine("h=5,w=3 rectangle");
            r.Draw();
            Console.WriteLine("s=4 square");
            s.Draw();
            Console.WriteLine("Rectangle turned into square");
            Square s2 = (Square)r;
            s2.Draw();

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        public int height { get; set; }
        public int width { get; set; }
        public Rectangle(int h, int w)
            : this()
        {
            height = h;
            width = w;
        }

        public Rectangle() { }
        public override string ToString()
        {
            return string.Format("Width is {0} and height is {1}", width, height);
        }
        public void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class Square
    {
        public int side { get; set; }
       
        public Square(int s)
            : this()
        {
            side = s;
        }

        public Square() { }
        public override string ToString()
        {
            return string.Format("Side is {0}", side);
        }
        public void Draw()
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        //Rectangle to square
        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square();
            s.side = r.height;
            return s;
        }
    }
}
