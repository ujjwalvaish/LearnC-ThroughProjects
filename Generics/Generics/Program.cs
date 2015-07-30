using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer_1 = EqualOrNot.Equal<int>(10, 20);
            Console.WriteLine(answer_1);
            bool answer_2 = EqualOrNot.Equal<string>("A", "A");
            Console.WriteLine(answer_2);
            bool answer_3 = IsEqual<int>.EqualityCheck(200, 200);
            Console.WriteLine(answer_3);
            bool answer_4 = EqualUsingObjects.EqualOrNot("AB", 12); //This is meaningless, that's why generics are used!
            Console.WriteLine(answer_4);
            Console.ReadKey();
        }
    }

    public class EqualOrNot
    {
        public static bool Equal<T>(T firstNumber, T secondNumber)//This method is generic
        {
            return firstNumber.Equals(secondNumber);
        }
   }

    public class IsEqual<T> //whole class can also be a generic , it will aplly to all the methods of that class
    {
        public static bool EqualityCheck(T fNumber, T sNumber)
        {
            return fNumber.Equals(sNumber);
        }
    }

    public class EqualUsingObjects
    {
        public static bool EqualOrNot(object first, object second) //Here first and second can be of any type. e.g. "AB" and 10 , it will have no meaning then
        {
            return first == second;
        }
    }
}
