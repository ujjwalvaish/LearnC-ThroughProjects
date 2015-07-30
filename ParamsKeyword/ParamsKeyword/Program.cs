using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SampleNumberArray1 = new int[4];
            SampleNumberArray1[0] = 100;
            SampleNumberArray1[1] = 101;
            SampleNumberArray1[2] = 102;
            SampleNumberArray1[3] = 103;

            

            Program2.ParamsMethod(); //Notice that this does not shows an error, by writing params in function , writing arguments becomes optional.

            Program2.ParamsMethod(SampleNumberArray1);

            Program2.ParamsMethod(0, 1, 2, 3, 4, 5, 6, 7, 8, 9); //Dynamic - On the fly , no aaray initiation etc. is needed for params method ,2nd use

        }
        class Program2
        {
            public static void ParamsMethod(params int[] Numbers)
            {
                Console.WriteLine("There are {0} elements ", Numbers.Length);
                foreach (int i in Numbers)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
               }
            }   
        }
    }

