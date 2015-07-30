using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
//polymorphism allows us to invoke the derived class methods through a base class reference during runtime.
//To do this , the base class method is defined as virtual and the derived class method is defined as override
{
   public class Employee
    {
        public string Fname = "Ujjwal";
        public string LName = "Vaish";

        public virtual void PrintFullName()
        {
            Console.WriteLine(Fname + " " + LName);
        }

    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(Fname + " " + LName + " -PT");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(Fname + " " + LName + " -FT");
        }

    }

    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(Fname + " " + LName + "-Temp");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] E = new Employee[4];   //Array of objects
            E[0] = new Employee();
            E[1] = new PartTimeEmployee();
            E[2] = new FullTimeEmployee();
            E[3] = new TemporaryEmployee();

            foreach (Employee e in E)
            {
                e.PrintFullName();
            }
            Console.ReadKey();
        }
    }
}
