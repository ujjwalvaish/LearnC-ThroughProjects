using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Instead of defining our custom delegates everytime , we can make use of the inbuilt Action (for return value void) and Func (for other return value) delegates

namespace ActionAndFuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> addmethod1 = new Action<int, int>(Add1);
            Func<int, int, int> addmethod2 = new Func<int, int, int>(Add2);
            addmethod1(2, 3);
            int y = addmethod2(1, 2);
            Console.WriteLine(y);
            Console.ReadKey();
        }

        public static void Add1(int x, int y)
        {
            Console.WriteLine("Result 1 is {0}",x+y);
        }

        public static int Add2(int x, int y)
        {
            return x + y;
        }

    }
}
-