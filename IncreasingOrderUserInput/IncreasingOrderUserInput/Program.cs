using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncreasingOrderUserInput
{

    class Program2
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[10];
            int count = 0;
            Console.WriteLine("Enter 10 nos");
            for (count = 0; count < 10; count++)
            {

                MyArray[count] = int.Parse(Console.ReadLine());
            }
            int temp, first, second;
            for (first = 0; first < 10; first++)
            {
                for (second = 0; second < 9; second++)
                {
                    if (MyArray[second] > MyArray[second + 1])
                    {
                        temp = MyArray[second];
                        MyArray[second] = MyArray[second + 1];
                        MyArray[second + 1] = temp;
                    }
                }
            }

            for (count = 0; count < 10; count++)
            {
                Console.WriteLine(MyArray[count]);
            }
            Console.ReadKey();
        }
    }
}

