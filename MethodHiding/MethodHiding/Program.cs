using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodHiding
{
    class Employee
    {
        public string name;
        public string lastname;
        public void printfullname()
        {
            Console.WriteLine(name + " " + lastname);
        }
    }


    class PartTimeEmployee : Employee
    {
        public new void printfullname()
        {
            Console.WriteLine(name + "-" + lastname + "-derived class"); //This will hide the method of the parent class . Notice the new keyword
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee P1 = new PartTimeEmployee();
            P1.name = "Ujjwal";
            P1.lastname = "Vaish";
            P1.printfullname();
            ((Employee)P1).printfullname(); //This is how we access the parent class method - Typecasting
            Console.ReadKey();
        }
    }
}