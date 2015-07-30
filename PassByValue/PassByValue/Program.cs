using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Notice that "i" does not change its value
//This is known as PassByValue
//This is because UserSelect makes a copy of "i" and changes its value to 100 , but original "i" remains the same
//Also note that the static method MyMethod1 is called directly , without giving the class name , as it resides in the same class
namespace PassByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            MyMethod1(i);
            Console.WriteLine(i);
            Console.ReadKey();
        }
        static void MyMethod1(int UserSelect)
        {
            UserSelect = 100;
        }
    }

}