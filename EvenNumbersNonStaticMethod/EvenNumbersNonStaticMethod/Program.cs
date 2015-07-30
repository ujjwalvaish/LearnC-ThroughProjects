using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenNumbersNonStaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an even number");
            Program P1 = new Program();
            int MyNumber = 0;
            MyNumber = int.Parse(Console.ReadLine());
            P1.DisplayEvenNumbers(MyNumber);
        }
        public void DisplayEvenNumbers(int UserChoice)
        {
            int n,a = 0;
            n = UserChoice;
            while(a <= UserChoice)
            {
                Console.WriteLine(a);
                a += 2;
            }
            Console.ReadKey();
        }
    }
}
