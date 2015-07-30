using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNumber = 10, sNumber = 20;
            Console.WriteLine(fNumber + "   " + sNumber);
            SwapAnything<int>(ref fNumber,ref sNumber); // <int> is optional
            Console.WriteLine(fNumber + "   " + sNumber);
            Console.ReadLine();
            
        }

        

        public static void SwapAnything<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent two arguments of type {0}",typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }

    
}
