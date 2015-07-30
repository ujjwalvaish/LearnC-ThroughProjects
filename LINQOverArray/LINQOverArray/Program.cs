using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryOverStrings();
            

            Console.ReadKey();
        }

        public static void QueryOverStrings()
        {
            string[] myArray = new string[]
            {
                "Ujjwal 1","Swati 2","Surabhi 3","Prakhar","Vipin","Manisha"
            };
            


            string[] myArrayWithSpaces = new string[myArray.Length];
            IEnumerable<string> subset = from g in myArray where g.Contains(" ") orderby g select g;
            foreach(string s in subset)
                Console.WriteLine(s);
            //Simpler method
            Console.WriteLine();
            Console.WriteLine("Using var");
            Console.WriteLine();
            var subset2 = from g in myArray where g.Contains(" ") orderby g select g;
            foreach (var s in subset)
            Console.WriteLine(s);
            ReflectOverQueryResults(subset2);
            ReflectOverQueryResults(subset);
      }
        public static void ReflectOverQueryResults(object resultSet)
        {
            Console.WriteLine();
            Console.WriteLine(resultSet.GetType());
        }
    }
}
