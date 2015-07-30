using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T parameter);
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDelegate<int> mydelegate1 = new MyGenericDelegate<int>(intdelegate);
            mydelegate1(25);
            mydelegate1 += intdelegate2;
            Console.WriteLine();
            mydelegate1(10);
            MyGenericDelegate<string> mydelegate2 = new MyGenericDelegate<string>(stringdelegate);
            mydelegate2("yo");

            Console.ReadKey();
        }

        public static void intdelegate(int x)
        {
            Console.WriteLine(x);
        }
        public static void intdelegate2(int x)
        {
            Console.WriteLine(x);
        }
        public static void stringdelegate(string abc)
        {
            Console.WriteLine(abc);
        }
    }
}
