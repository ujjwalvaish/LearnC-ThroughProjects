using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenNumbersStaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an even number");
            int UserSelect = 0;
            UserSelect = int.Parse(Console.ReadLine());

            Program.EvenNumbers(UserSelect);
        }

        public static void EvenNumbers(int a)
        {
            int i=0,UserChoice = 0;
            UserChoice = a;
            while (i <= UserChoice)
            {
                Console.WriteLine(i);
                i += 2;
            }
            Console.ReadKey();
        }


    }
}
