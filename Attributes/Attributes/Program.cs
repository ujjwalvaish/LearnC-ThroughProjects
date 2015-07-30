using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Attributes allow you to add declarative information to your programs which can then be queried at runtime using reflection
//There are several predefined attributes provided by .NET like Obsolete,Table,Webmethod,Serializable . We can create our own customized attributes.
//It is possible to customize attributes using parameters
//All attributes inherit from System.Attributes base class
//ObsoleteAttribute has "Attribute" keyword as optional
namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AttributeExample.AddNos(1, 2);

            Console.WriteLine(result);
            List<int>  Nums =  new List<int>(){1,2,3,4};
            int result2 = AttributeExample.AddNos(Nums);
            Console.WriteLine(result2);
            Console.ReadKey();
        }
        
       }

    class AttributeExample
    {
        [Obsolete("Please use AddNos(List<int> Numbers) method instead",false)]
        public static int AddNos(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int AddNos(List<int> Numbers)
        {
            int sum = 0;
            foreach (int number in Numbers)
            {
                sum = sum + number;
            }
            return sum;
        }

    }
}
