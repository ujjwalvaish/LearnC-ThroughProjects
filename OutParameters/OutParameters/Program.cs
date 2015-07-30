using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//This program explains the scenario if we want to return two values
//Notice the out parametes , both in definition and while invoking
//Also , notice, since we have mentioned the out parameters , we will write void in the definition of the method
namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, product;
            TwoNumberSumProd(10, 20, out sum, out product);
            Console.WriteLine("Sum is {0} & Product is {1}", sum, product);
            Console.ReadKey();
        }
        static void TwoNumberSumProd(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }
    }
}
