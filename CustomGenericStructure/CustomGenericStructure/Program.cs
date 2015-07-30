using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomGenericStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericPoint<int> p1 = new GenericPoint<int>(1, 2);
            Console.WriteLine(p1.ToString());
            GenericPoint<double> p2 = new GenericPoint<double>(1.1, 2.2);
            Console.WriteLine(p2.ToString());
            Console.Read();

        }
    }

    public struct GenericPoint<T>
    {
        private T X;
        private T Y;

        public T XPos
        {
            get
            { return X; }
            set
            { X = value; }
        }

        public T YPos
        {
            get
            { return Y; }
            set
            { Y = YPos; }
        }
        

        public GenericPoint( T xpos, T ypos)
        {
            X = xpos;
            Y = ypos;
        }
        public override string ToString()
        {
            return string.Format("Value of X is {0} and value of Y is {1}", X, Y);
        }

        public void Reset()
        {
            X = default(T);
            Y = default(T);
        }
    }
}
