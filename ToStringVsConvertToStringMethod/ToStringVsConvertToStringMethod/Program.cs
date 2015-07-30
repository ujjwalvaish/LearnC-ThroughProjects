using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToStringVsConvertToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            Console.WriteLine("Via ToString Method : {0}", C1.ToString());
            Console.WriteLine("Via ConvertToString Method : {0}",Convert.ToString(C1));

            Console.ReadKey();

            Customer C2 = null;
            Console.WriteLine(C2.ToString()); //throws a null type reference exception
            Console.WriteLine(Convert.ToString(C2));//Handles null
            //So, we can use any of them depending upon the kind of app and architecture
        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}
