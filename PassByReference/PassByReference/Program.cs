using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Notice that "i" changes its value
//This is known as PassByReference
//This is because UserSelect does not make a copy of "i" and points to the same location as i
//Also note that the static method MyMethod1 is called directly , without giving the class name , as it resides in the same class
namespace PassByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            MyMethod1(ref i);
            Console.WriteLine(i);
            Console.ReadKey();
        }
        static void MyMethod1(ref int UserSelect)
        {
            UserSelect = 100;
        }
    }

}